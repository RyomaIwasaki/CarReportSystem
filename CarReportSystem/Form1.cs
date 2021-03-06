﻿using System;
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
            //dgvItiran.DataSource = _Cars;
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

        }

        //修正ボタン
        private void btSyusei_Click(object sender, EventArgs e)
        {
            dgvItiran.CurrentRow.Cells[1].Value = dtpDate.Value;
            dgvItiran.CurrentRow.Cells[2].Value = cbName.Text;
            dgvItiran.CurrentRow.Cells[3].Value = getMakerRadioButton();
            dgvItiran.CurrentRow.Cells[4].Value = cbCarName.Text;
            dgvItiran.CurrentRow.Cells[5].Value = tbReport.Text;

            if (pbImage.Image != null)
            {
                dgvItiran.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);
            }
            else
            {
                dgvItiran.CurrentRow.Cells[6].Value = null;
            }


            //データベース更新（反映）
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202013DataSet);

            inputItemAllClear();


        }

        private void dgvData_Click(object sender, EventArgs e)
        {
            var test = dgvItiran.CurrentRow.Cells[2].Value;



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


            //if (dgvItiran.Columns[3] == トヨタ)
            //{
            //    rbToyota.Checked = true;
            //}
            //else if (dgvItiran.Columns[3].Visible == 日産)
            //{
            //    rbNissan.Checked = true;
            //}
            //else if (dgvItiran.Columns[3].Visible == ホンダ)
            //{
            //    rbHonda.Checked = true;
            //}
            //else if (dgvItiran.Columns[3].Visible == スバル)
            //{
            //    rbSubaru.Checked = true;
            //}
            //else if (dgvItiran.Columns[3].Visible == 外車)
            //{
            //    rbGaisya.Checked = true;
            //}
            //else 
            //{
            //    rbSonota.Checked = true;
            //}
        }

        //接続ボタン
        private void btHirekuData_Click(object sender, EventArgs e)
        {
            this.carReportTableAdapter.Fill(this.infosys202013DataSet.CarReport);
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
            // TODO: このコード行はデータを 'infosys202013DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.carReportTableAdapter.Fill(this.infosys202013DataSet.CarReport);
            dgvItiran.Columns[0].Visible = false;



        }

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202013DataSet);

        }



        private void carReportBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void carReportBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        //一覧表のデータ選択
        private void dgvItiran_Click(object sender, EventArgs e)
        {
            //選択したレコードのインデックスで指定した項目を取り出す
            string maker = dgvItiran.CurrentRow.Cells[3].Value.ToString();

            dtpDate.Value = (DateTime)dgvItiran.CurrentRow.Cells[1].Value;
            cbName.Text = dgvItiran.CurrentRow.Cells[2].Value.ToString();
            cbCarName.Text = dgvItiran.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = dgvItiran.CurrentRow.Cells[5].Value.ToString();

            try
            {
                pbImage.Image = ByteArrayToImage((byte[])dgvItiran.CurrentRow.Cells[6].Value);
            }
            catch (Exception ex)
            {

            }

            //ラジオボタンの設定
            setMakerRadioButton((string)maker);

        }

        private void setMakerRadioButton(string carMaker)
        {
            switch (carMaker)
            {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;

                case "日産":
                    rbNissan.Checked = true;
                    break;

                case "ホンダ":
                    rbHonda.Checked = true;
                    break;

                case "スバル":
                    rbSubaru.Checked = true;
                    break;

                case "外車":
                    rbGaisya.Checked = true;
                    break;

                case "その他":
                    rbSonota.Checked = true;
                    break;
            }
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] byteData)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(byteData);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] byteData = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return byteData;
        }

        private void dgvItiran_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbMaker_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvItiran.CurrentRow.Cells[1].Value = dtpDate.Value;
            dgvItiran.CurrentRow.Cells[2].Value = cbName.Text;
            //dgvItiran.CurrentRow.Cells[3].Value = setMakerRadioButton((string)maker);
            dgvItiran.CurrentRow.Cells[4].Value = cbCarName.Text;
            dgvItiran.CurrentRow.Cells[5].Value = tbReport.Text;
            dgvItiran.CurrentRow.Cells[6].Value = pbImage.Image;
        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }

        private string getMakerRadioButton()
        {
            if (rbToyota.Checked)
            {
                return rbToyota.Text;
            }
            else if (rbNissan.Checked)
            {
                return rbNissan.Text;
            }
            else if (rbHonda.Checked)
            {
                return rbHonda.Text;
            }
            else if (rbSubaru.Checked)
            {
                return rbSubaru.Text;
            }
            else if (rbGaisya.Checked)
            {
                return rbGaisya.Text;
            }
            else if (rbSonota.Checked)
            {
                return rbSonota.Text;
            }
            else
            {
                return "null";
            }
        }

        private void btSeachExe_Click(object sender, EventArgs e)
        {

            this.carReportTableAdapter.FillByCarName(this.infosys202013DataSet.CarReport, tbSearchCarName.Text, tbSearchMaker.Text);

            this.carReportTableAdapter.FillByCarName(this.infosys202013DataSet.CarReport, tbSearchCarName.Text, tbSearchMaker.Text);


            this.carReportTableAdapter.FillByCarDate(this.infosys202013DataSet.CarReport, dtbSearchDate.Value.ToString());

        }
    }
}
