using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace TranscendAutoDownloader
{
    class ParseTsList
    {
        public List<string> listeDateien = new List<string>();
        public List<string> listeOrdner = new List<string>();

        public ParseTsList(string input)
        {
//            input = @"TS list1
//List Files = /www/sd/DCIM/100CANON/
//FileName0=IMG_8457.CR2&FileType0=File&FileName1=IMG_8458.CR2&FileType1=File&FileName2=IMG_8459.JPG&FileType2=File&FileName3=IMG_8460.JPG&FileType3=File&FileName4=IMG_8461.JPG&FileType4=File&FileName5=IMG_0060.CR2&FileType5=File&FileName6=2013-08-24_Unzucht_Bild_1016.jpg&FileType6=File&FileName7=IMG_8462.JPG&FileType7=File&FileName8=IMG_8463.JPG&FileType8=File&FileName9=IMG_8464.JPG&FileType9=File&FileName10=IMG_8465.JPG&FileType10=File&FileName11=IMG_8466.JPG&FileType11=File&FileName12=IMG_8467.JPG&FileType12=File&FileCount=13";

//            input = @"TS list1
//List Files = /www/sd/DCIM
//FileName0=100CANON&FileType0=Directory&FileName1=EOSMISC&FileType1=Directory&FileCount=2";

            var bestandteile = input.Split(new char[] { '\r', '\n' },StringSplitOptions.RemoveEmptyEntries);

            var liste = HttpUtility.UrlDecode(bestandteile[2]).Split('&');

            for (int index = 0; index < liste.Length-1; index=index+2)
            {
                var s1 = liste[index].Split('=');
                var s2 = liste[index + 1].Split('=');

                if (s2[1].Contains("File"))
                {
                    listeDateien.Add(s1[1]);
                }
                if (s2[1].Contains("Directory"))
                {
                    listeOrdner.Add(s1[1]);
                }

            }

            var anzahl = Int32.Parse(liste[liste.Length - 1].Split('=')[1]);
            if (anzahl != (listeDateien.Count + listeOrdner.Count))
            {
                MessageBox.Show(string.Format("Es wurden {0} Dateien und {1} Ordner eingelesen. Gemeldet wurden aber {2} Dateien! Prüfen!!",listeDateien.Count, listeOrdner.Count,anzahl));
            }

        }

    }
}
