using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.IO;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        BindingList<CarReport> _Cars = new BindingList<CarReport>();
        public Form1()
        {
            InitializeComponent();
            dgvItiran.DataSource = _Cars;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            CarReport obj = new CarReport
            {
                CreatDate = dtpDate.Value,
                Author = cbName.Text,
                Maker = MakerSerect(),
                Name = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbImage.Image,
            };

            //BindingListへ登録
            //_Cars.Add(obj);
            _Cars.Insert(0, obj); //リストの先頭（インデックス０）へ追加
            

            setComboBoxMaker(cbCarName.Text);
            setComboBoxAuthor(cbName.Text);

            inputItemAllClear();
            initButtons();
        }

        //メーカーコンボボックスの入力候補登録
        private void setComboBoxMaker(string maker)
        {
            if (!cbCarName.Items.Contains(maker))
            {
                //コンボボックスの候補に追加
                cbCarName.Items.Add(maker);
            }
        }

        private void setComboBoxAuthor(string author)
        {
            if (!cbName.Items.Contains(author))
            {
                //コンボボックスの候補に追加
                cbName.Items.Add(author);
            }
        }

        private void inputItemAllClear()
        {
            cbName.Text = "";
            cbCarName.Text = "";
            rbClear();
            tbReport.Text = "";
            pbImage.Image = null;

        }

        //ラジオボタンの選択解除
        private void rbClear()
        {
            rbToyota.Checked = false;
            rbNissan.Checked = false;
            rbHonda.Checked = false;
            rbSubaru.Checked = false;
            rbGaisya.Checked = false;
            rbSonota.Checked = false;
        }



        private void dgvItiran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItiran.CurrentRow == null)
                return;

            //選択したレコードを取り出す
            //データグリッドビューで選択した行のインデックスを元に
            //BindingListのデータを取得する
            CarReport selectedCar = _Cars[dgvItiran.CurrentRow.Index];
            dtpDate.Value = selectedCar.CreatDate;
            cbName.Text = selectedCar.Author;
            MakerCheck();
            cbCarName.Text = selectedCar.Name;
            tbReport.Text = selectedCar.Report;
            pbImage.Image = selectedCar.Picture;
        }

        private void btHirakuImage_Click(object sender, EventArgs e)
        {
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                //選択した画像をピクチャーボックスに表示
                pbImage.Image = Image.FromFile(ofdImage.FileName);
                //ピクチャーボックスのサイズに画像を調整
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private CarMaker MakerSerect()
        {
            if (rbToyota.Checked == true)
            {
                return CarMaker.トヨタ;
            }
            else if (rbNissan.Checked == true)
            {
                return CarMaker.日産;
            }
            else if (rbHonda.Checked == true)
            {
                return CarMaker.ホンダ;
            }
            else if (rbSubaru.Checked == true)
            {
                return CarMaker.スバル;
            }
            else if (rbGaisya.Checked == true)
            {
                return CarMaker.外車;
            }
            else if (rbSonota.Checked == true)
            {
                return CarMaker.その他;
            }

            return CarMaker.DEFAULT;
        }

        private void btDeleteImage_Click(object sender, EventArgs e)
        {

            if (pbImage.Image == null)
                return;

            if (MessageBox.Show("削除してもよいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                pbImage.Image = null;
            }
            
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //セーブファイルダイアログを表示
            if (sfdSaveData.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                //ファイルストリームを生成
                using (FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create))
                {
                    try
                    {
                        //シリアル化して保存
                        formatter.Serialize(fs, _Cars);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        }

        private void btSyusei_Click(object sender, EventArgs e)
        {

            //変更対象のレコード（オブジェクト）
            CarReport selectedCar = _Cars[dgvItiran.CurrentRow.Index];
            selectedCar.CreatDate = dtpDate.Value;
            selectedCar.Author = cbName.Text;
            selectedCar.Maker = MakerSerect();
            selectedCar.Report = tbReport.Text;
            selectedCar.Picture = pbImage.Image;

            dgvItiran.Refresh();       //データグリッドビューの再描画
        }

        private void dgvData_Click(object sender, EventArgs e)
        {
            if (dgvItiran.CurrentRow == null)
                return;

            //選択したレコードを取り出す
            //データグリッドビューで選択した行のインデックスを元に
            //BindingListのデータを取得する
            CarReport selectedCar = _Cars[dgvItiran.CurrentRow.Index];
            inputItemAllClear();
            dgvItiran.ClearSelection();

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            _Cars.RemoveAt(dgvItiran.CurrentRow.Index);
            inputItemAllClear();
            dgvItiran.ClearSelection();
        }

        private void btEmd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MakerCheck()
        {
            CarReport selectedCar = _Cars[dgvItiran.CurrentRow.Index];
            if (selectedCar.Maker == CarMaker.トヨタ)
            {
                rbToyota.Checked = true;
            }
            else if (selectedCar.Maker == CarMaker.日産)
            {
                rbNissan.Checked = true;
            }
            else if (selectedCar.Maker == CarMaker.ホンダ)
            {
                rbHonda.Checked = true;
            }
            else if (selectedCar.Maker == CarMaker.スバル)
            {
                rbSubaru.Checked = true;
            }
            else if (selectedCar.Maker == CarMaker.外車)
            {
                rbGaisya.Checked = true;
            }
            else if (selectedCar.Maker == CarMaker.その他)
            {
                rbSonota.Checked = true;
            }
        }

        private void btHirekuData_Click(object sender, EventArgs e)
        {
            if (ofdOpenData.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofdOpenData.FileName, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        //逆シリアル化して読み込む
                        _Cars = (BindingList<CarReport>)formatter.Deserialize(fs);
                        //データグリッドビューに再設定
                        dgvItiran.DataSource = _Cars;
                        //選択されている箇所を各コントロールへ表示
                        dgvData_Click(sender, e);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        }

        private void initButtons()
        {
            if (_Cars.Count > 0)
            {
                btSyusei.Enabled = true;
                btDelete.Enabled = true;
            }
            else
            {
                btSyusei.Enabled = false;
                btDelete.Enabled = false;
            }
        }

        private void FoomRead(object sender, EventArgs e)
        {
            if (_Cars.Count > 0)
            {
                btSyusei.Enabled = true;
                btDelete.Enabled = true;
            }
            else
            {
                btSyusei.Enabled = false;
                btDelete.Enabled = false;
            }
        }
    }
}
