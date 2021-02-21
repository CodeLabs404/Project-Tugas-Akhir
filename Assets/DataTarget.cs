using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Vuforia { 

public class DataTarget : MonoBehaviour
{
        public Transform TextTargetName;
        public Transform TextDescription;
        public Transform ButtonAction;
        public Transform PanelDescription;
        public Transform PanelPopup;
        public Transform TextPopup;


        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

            foreach (TrackableBehaviour tb in tbs)
            {
                string name = tb.TrackableName;
                ImageTarget it = tb.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);

                //Evertime the target found it will show “name of target” on the TextTargetName. Button, Description and Panel will visible (active)

                TextTargetName.GetComponent<Text>().text = name;
                ButtonAction.gameObject.SetActive(true);
                TextDescription.gameObject.SetActive(true);
                PanelDescription.gameObject.SetActive(true);
                PanelPopup.gameObject.SetActive(false);
                TextPopup.gameObject.SetActive(false);

                //Apabila Object Singkal dimunculkan maka akan memunculkan deskripsi Singkal.

                if (name == "SINGKAL")
                {
                    TextDescription.GetComponent<Text>().text = "Singkal merupakan bagian wuluku atau alat membajak sawah yang berfungsi untuk mengembalikan tanah yang terbawa oleh wuluku supaya berposisi tertelungkup. Singkal ini berbahan dasar dari kayu keras dan biasanya pada bagian bawah dipasang lanjam (pisau tanah yang terbuat dari besi). Belum diketahui tahun munculnya alat membajak sawah tradisional ini, akan tetapi pada era pertanian modern seperti sekarang ini, masih ada para petani yang menggunakan alat singkal ini. Singkal yang terdapat di museum Ki Pahare diperoleh di desa Wangunreja Kabupaten Sukabumi";
                }

                // Apabila Object Poci dimunculkan maka akan memunculkan deskripsi Poci.

                if (name == "POCI")
                {
                    TextDescription.GetComponent<Text>().text = "Poci atau teko adalah suatu wadah yang digunakan untuk menjerang daun teh atau campuran herbal dengan air yang hampir mendidih. Poci ini didapat pada pameran budaya yang diselenggarakan di Cianjur Jawa Barat. Menurut panitia penyelenggara pameran, poci ini dulunya dimiliki oleh keluarga tionghoa yang pada masanya memiliki kelas sosial yang terpandang";
                }

                // Apabila Object Rebab Tarawangsa dimunculkan maka akan memunculkan deskripsi Rebab Tarawangsa.

                if (name == "REBAB_TARAWANGSA")
                {
                    TextDescription.GetComponent<Text>().text = "Tarawangsa merupakan salah satu jenis kesenian rakyat Jawa Barat. Istilah tarawangsa sendiri memiliki pengertian sebagai alat musik gesek yang memiliki dua dawai yang terbuat dari kawat baja atau besi. Alat musik gesek ini awalnya dimainkan berkaitan dengan upacara padi, yakni menjelang dan setelah panen. Rebab Tarawangsa yang dipamerkan museum Ki Pahare ini asli milik dari paguyuban Ki Pahare";
                }

                // Apabila Object Saron dimunculkan maka akan memunculkan deskripsi Saron.

                if (name == "SARON")
                {
                    TextDescription.GetComponent<Text>().text = "Saron atau yang biasanya disebut juga ricik adalah salah satu instrumen gamelan yang termasuk keluarga balungan. Saron memiliki alat penabuh (seperti alat pemukul agar mengeluarkan bunyi nada) yang pada umumnya terbuat dari bahan kayu yang berbentuk seperti palu. Saron yang dipamerkan museum Ki Pahare ini merupakan aset asli dari paguyuban Ki Pahare yang digunakan pada saat ada upacara kebudayaan";
                }

                // Apabila Object Badik dimunculkan maka akan memunculkan deskripsi Badik.

                if (name == "BADIK")
                {
                    TextDescription.GetComponent<Text>().text = "Badik adalah senjata yang hampir sama dengan pisau, namun pegangannya tidak lurus yang bersisi tajam tunggal. Ukurannya lebih kecil dari pisau. Badik ini merupakan peninggalan dari R. Wangsa Koesoema yang merupakan asisten Wadana Baros yang menjabat pada tahun 1890-1895";
                }

                // Apabila Object Bonang dimunculkan maka akan memunculkan deskripsi Bonang.

                if (name == "BONANG")
                {
                    TextDescription.GetComponent<Text>().text = "Bonang merupakan alat musik tradisional Indonesia yang digunakan dalam gamelan Jawa. Bonang ini merupakan gong versi mini yang ada pada Degung Gamelan Sunda. Bonang yang terdapat di museum Ki Pahare ini merupakan aset asli dari paguyuban Ki Pahare yang digunakan pada saat upacara kebudayaan";
                }

                // Apabila Object Botol dimunculkan maka akan memunculkan deskripsi Botol.

                if (name == "BOTOL_HUSTLCAMP")
                {
                    TextDescription.GetComponent<Text>().text = "Botol era Kolonial Belanda yang dinamakan Bottle Hulstkamp dengan ukuran 1 liter yang diperkirakan dibuat pada tahun 1880. Botol ini didapat seorang warga yang mengoleksi barang-barang antik. Pada masanya botol ini digunakan untuk menyimpan air anggur beralkohol";
                }

                // Apabila Object Gong dimunculkan maka akan memunculkan deskripsi Gong.

                if (name == "GONG")
                {
                    TextDescription.GetComponent<Text>().text = "Gong merupakan sebuah alat musik pukul yang terkenal di Asia Tenggara dan Asia Timur. Gong ini digunakan untuk alat musik tradisional. Gong ini merupakan aset asli yang dimiliki oleh Paguyuban Ki Pahare yang digunakan ketika ada upacara Kebudayaan";
                }

                // Apabila Object Pangarih dimunculkan maka akan memunculkan deskripsi Pangarih.

                if (name == "PANGARIH")
                {
                    TextDescription.GetComponent<Text>().text = "Pangarih adalah perabot dapur tradisional Sunda yang berfungsi sebagai alat untuk ngakeul (menanak) nasi yang terbuat dari kayu. Jaman sekarang pangarih yang terbuat dari kayu sudah jarang digunakan, masyarakat sering menggunakan pangarih dari bahan plastik. Pangarih ini diperoleh di Desa Cijangkar Nyalindung Kabupaten Sukabumi";
                }

                // Apabila Object Mangkuk dimunculkan maka akan memunculkan deskripsi Mangkuk.

                if (name == "MANGKUK_ANTIK")
                {
                    TextDescription.GetComponent<Text>().text = "Mangkuk antik merek Petrus Regout & Co MAASTRICHT. Mangkuk ini adalah buatan Holland yang dipesan untuk dikirim ke Jawa terbukti dengan adanya tulisan Jawa Kuno yang digunakan. Diproduksi sekitar tahun 1834. Pemilik dari mangkuk antik ini adalah Lis Nurwijanah. Menurut pemilik, mangkuk tersebut merupakan peninggalan Demang TjiKembar pada masa Kolonial Belanda";
                }

                // Apabila Object Lulumpang dimunculkan maka akan memunculkan deskripsi Lulumpang.

                if (name == "LULUMPANG")
                {
                    TextDescription.GetComponent<Text>().text = "Lulumpang merupakan perkakas dapur yang digunakan oleh masyarakat suku Sunda untuk menumbuk rempah-rempah agar menjadi halus ketika di masak. Lulumpang ini didapat dari seseorang asli Baros yang bernama Ibu Siti Jubaediyah dan di hibahkan ke museum Ki Pahare";
                }

                // Apabila Object Keris dimunculkan maka akan memunculkan deskripsi Keris.

                if (name == "KERIS")
                {
                    TextDescription.GetComponent<Text>().text = "Pada masa kerajaan dulu di Jawa, keris-keris ber-luk5 hanya dimiliki oleh seorang Raja, Pangeran dan Keluarga Raja. Selain mereka tidak ada lain yang boleh memiliki atau menyimpan keris tersebut. Berdasarkan informasi dari pemilik, keris ini merupakan peninggalan leluhurnya yang diwariskan secara turun temurun";
                }

                // Apabila Object Helm dimunculkan maka akan memunculkan deskripsi Helm.

                if (name == "HELM_PRAJURIT")
                {
                    TextDescription.GetComponent<Text>().text = "Helm tersebut digunakan oleh pasukan tentara Jepang pada perang dunia ke 2 saat Jepang menjajah di Indonesia. Helm ini didapatkan dari hibah seorang warga yang berasal dari daerah Banten";
                }

                // Apabila Object Bokor dimunculkan maka akan memunculkan deskripsi Bokor.

                if (name == "BOKOR")
                {
                    TextDescription.GetComponent<Text>().text = "Bokor adalah sebuah tempat yang digunakan untuk membuang ampas ketika nyirih atau nyeupah. Selain bokor ini, ada juga bokor-bokor kecil tempat menyimpan sirih, kapur dan gambir. Berdasarkan informasi yang disampaikan oleh pemilik bahwa bokor ini merupakan peninggalan Wadana Tjiheulang yaitu Rd. Mas Djajeng Rana pada tahun 1880";
                }

                // Apabila Object Tombak dimunculkan maka akan memunculkan deskripsi Tombak.

                if (name == "TOMBAK")
                {
                    TextDescription.GetComponent<Text>().text = "Kepala tombak ini merupakan peninggalan Kerajaan Padjajaran pada abad ke-16 Masehi. Biasa digunakan oleh penjaga istana dan juga ajudan Raja. Tombak ini didapatkan dari sebuah komunitas yang bergerak dalam pelestarian budaya dan juga barang antik bersejarah";
                }

                // Apabila Object Tas dimunculkan maka akan memunculkan deskripsi Tas.

                if (name == "TAS_KANERON")
                {
                    TextDescription.GetComponent<Text>().text = "Kaneron adalah sebuah tas yang dibuat dari anyaman kulit rotan (hoe). Jenisnya ada yang memakai tutup ada juga yang tidak. Kaneron merupakan jenis tas yang sangat khas digunakan oleh masyarakat Sunda. Hampir disetiap daerah yang ada di Jawa Barat memproduksi tas tersebut";
                }

                // Apabila Object Setrika dimunculkan maka akan memunculkan deskripsi Setrika.

                if (name == "SETRIKA_ARANG")
                {
                    TextDescription.GetComponent<Text>().text = "Setrika arang dengan khiasa ayam jago ini tidak tau pasti kapan ditemukannya. Setrika tersebut bisa diisi batu bara atau arang yang membara agar dapat memanaskan logam di bawahnya. Setrika arang ini didapatkan pada saat pameran kebudayaan yang diselenggarakan di daerah Banten, Jawa Barat";
                }

                // Apabila Object Etem dimunculkan maka akan memunculkan deskripsi Etem.

                if (name == "ETEM")
                {
                    TextDescription.GetComponent<Text>().text = "Etem adalah sebuah pisau kecil yang dipakai untuk memanen padi. Pada saat memanen padi, masyarakat tradisional Sunda tidak boleh menggunakan arit atau golok untuk memanen padi mereka harus menggunakan etem pisau kecil yang disembunyikan di telapak tangan. Masyarakat Sunda percaya bahwa Dewi padi yaitu Nyai Sri Pohaci akan ketakutan melihat senjata tajam yang besar seperti arit atau golok";
                }

                // Apabila Object Lesung dimunculkan maka akan memunculkan deskripsi Lesung.

                if (name == "LESUNG")
                {
                    TextDescription.GetComponent<Text>().text = "Lesung adalah alat tradisional dalam pengolahan padi atau gabah menjadi beras. Fungsi alat ini memisahkan kulit gabah dari beras secara mekanik. Lesung terbuat dari kayu berbentuk perahu. Padi yang akan diolah disimpan dilubang tersebut lalu ditumbuk dengan halu, berulang-ulang sampai beras terpisah dari sekam";
                }

                // Apabila Object Lampu Kereta dimunculkan maka akan memunculkan deskripsi Lampu Kereta.

                if (name == "LAMPU_SINYAL_KERETA")
                {
                    TextDescription.GetComponent<Text>().text = "Lampu sinyal kereta api ini mirip seperti lampu lalu lintas yang fungsinya memberi isyarat berupa bentuk, warna ataupun cahaya kepada masinis kereta untuk mengatur dan mengontrol pengoperasian kereta api. Lampu sinyal kereta api ini digunakan pada saat penjajah tentara Jepang di Indonesia. Menurut informasi dari pemilik, lampu sinyal kereta ini dimilikinya turun temurun yang dulunya merupakan pekerja dari statsiun kereta Soekaboemi";
                }
            }
        }
    }
}
