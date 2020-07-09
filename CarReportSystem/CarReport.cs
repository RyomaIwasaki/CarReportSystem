using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem
{
    [Serializable]
    class CarReport
    {
        //登録日
        public DateTime CreatDate { get; set; }
        //登録者
        public string Author { get; set; }
        //メーカー
        public CarMaker Maker { get; set; }
        //車名
        public string Name { get; set; }
        //レポート
        public string Report { get; set; }
        //画像
        public Image Picture { get; set; }

    }

    public enum CarMaker
    {
        DEFAULT,
        トヨタ,
        日産,
        ホンダ,
        スバル,
        外車,
        その他,
    }
}
