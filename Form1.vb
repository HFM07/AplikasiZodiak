Public Class Form1
    'By Habib Fauzan Mahardika 9882405120111014
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Nama, Status, Pekerjaan As String
        Dim tanggal, Bulan As Integer
        Dim NamaBulan As String
        NamaBulan = " "
        Nama = TXT_Nama.Text
        Status = TXT_Status.Text
        Pekerjaan = TXT_Pekerjaan.Text
        'LBL_Nama.Hide()
        'LBL_Pekerjaan.Hide()
        'LBL_Status.Hide()
        'LBL_Nama.Text = Nama
        'LBL_Pekerjaan.Text = Pekerjaan
        'LBL_Status.Text = Status
        For tanggal = 1 To 31
            CMB_Tanggal.Items.Add(tanggal)
        Next
        For Bulan = 1 To 12
            If Bulan = 1 Then
                NamaBulan = "Januari" '31
            ElseIf Bulan = 2 Then
                NamaBulan = "Februari" '28/29
            ElseIf Bulan = 3 Then
                NamaBulan = "Maret" '31
            ElseIf Bulan = 4 Then
                NamaBulan = "April" '30
            ElseIf Bulan = 5 Then
                NamaBulan = "Mei" '31
            ElseIf Bulan = 6 Then
                NamaBulan = "Juni" '30
            ElseIf Bulan = 7 Then
                NamaBulan = "Juli" '31
            ElseIf Bulan = 8 Then
                NamaBulan = "Agustus" '31
            ElseIf Bulan = 9 Then
                NamaBulan = "September" '30
            ElseIf Bulan = 10 Then
                NamaBulan = "Oktober" '31
            ElseIf Bulan = 11 Then
                NamaBulan = "November" '30
            ElseIf Bulan = 12 Then
                NamaBulan = "Desember" '31
            End If
            CMB_Bulan.Items.Add(NamaBulan)
        Next
        For i = 1980 To 2010
            CMB_Tahun.Items.Add(i)
        Next
    End Sub
    'By Habib Fauzan Mahardika 9882405120111014
    Private Sub BTN_Cek_Zodiak_Click(sender As Object, e As EventArgs) Handles BTN_Cek_Zodiak.Click
        Dim SifatAries, SifatTaurus, SifatGemini, SifatCancer, SifatLeo, SifatVirgo, SifatLibra, SifatScorpio, SifatSagitarius, SifatCapricorn, SifatAquarius, SifatPisces As String
        Dim HubunganAries, HubunganTaurus, HubunganGemini, HubunganCancer, HubunganLeo, HubunganVirgo, HubunganLibra, HubunganScorpio, HubunganSagitarius, HubunganCapricorn, HubunganAquarius, HubunganPisces As String
        Dim EmosiAries, EmosiTaurus, EmosiGemini, EmosiCancer, EmosiLeo, EmosiVirgo, EmosiLibra, EmosiScorpio, EmosiSagitarius, EmosiCapricorn, EmosiAquarius, EmosiPisces As String
        Dim Tanggal2, Bulan2 As String
        Tanggal2 = CMB_Tanggal.Text
        Bulan2 = CMB_Bulan.Text

        'Zodiak Capricorn
        SifatCapricorn = "Bijaksana dan pekerja keras"
        HubunganCapricorn = "Sangat berhati hati saat memilih pasangan karena tidak ingin membuang waktu untuk sesuatu yang tidak mereka diinginkan"
        EmosiCapricorn = "Ketika marah, bukan hanya perkataanya saja yang menyakitkan untuk didengar, namun mereka juga suka mengekspresikan amarahnya dengan melempar dan menhancurkan benda"

        'Zodiak Aquarius
        SifatAquarius = "Tenang dan mudah bergaul"
        HubunganAquarius = "Suka bergerak perlahan dalam berhubungan, jika tidak berjalan sesuai dengan yang direncanakan mereka, itu bisa menjadi sesuatu yang sulit"
        EmosiAquarius = "Memilih untuk menghindar, menjauh bahkan mengasingkan diri dari sesuatu yang memancing amarah"

        'Zodiak Pisces
        SifatPisces = "Romantis dan peduli"
        HubunganPisces = "Tidak dapat memprediksi apa yang ada dalam pikiran mereka dan bagaimana mengelola ekspektasi mereka"
        EmosiPisces = "Mereka diketahui tidak mudah terpancing emosi, apalagi hanya karena masalah-masalah sepele. Namun, bukan berarti mereka tidak bisa marah. Jika kesabaran seorang Pisces sudah habis, mereka bisa menjadi meledak-ledak bahkan bertindak kasar kepada orang yang telah membuatnya marah."

        'Zodiak Aries
        SifatAries = "Energik dan penuh kreatifitas"
        HubunganAries = "Mereka menyukai kejutan dan membuat rencana dadakan. Mereka mengharapkan pasangannya memanjakan mereka, dan sulit untuk mempertahankan hubungan jangka panjang jika tuntutan mereka tidak dipenuhi."
        EmosiAries = "Tidak bisa mengontrol amarah yang dirasakan. Mau itu di tempat sepi ataupun di tempat ramai, kalau mereka sudah marah maka mereka tidak akan segan untuk mengekspresikan kemarahannya"

        'Zodiak Taurus
        SifatTaurus = "Tekun dan sabar"
        HubunganTaurus = "Mereka menginginkan hubungan jangka panjang dan mencari pasangan yang dapat memberi mereka stabilitas yang mereka inginkan. Mereka menjadi pasangan yang hebat"
        EmosiTaurus = "Taurus biasanya akan lebih banyak diam ketika sedang marah. Mereka lebih suka bersikap dingin dan tak menghiraukan seseorang yang telah membuatnya marah. Namun, jika orang itu tidak segera sadar dengan kesalahannya, bisa dipastikan Taurus akan mulai banyak mengomel dan siap meledakkan seluruh amarahnya."

        'Zodiak Gemini
        SifatGemini = "Cerdas dan berkarisma"
        HubunganGemini = "Mereka cenderung berubah cukup cepat. Karena mereka dapat dengan cepat menganalisis dua sisi situasi atau orang, perilaku mereka terkadang dapat berubah dengan cepat, membuat pasangannya merasa tidak nyaman dan tidak yakin dengan harapan mereka."
        EmosiGemini = "Cenderung memiliki gaya marah yang berbeda-beda. Terkadang mereka bisa bersikap blak-blakan dan langsung memarahi orang yang telah berani membuatnya marah tetapi juga bisa bersikap diam seribu bahasa tanpa mau bersikap ramah kepada orang tersebut."

        'Zodiak Cancer
        SifatCancer = "Penuh perhatian dan memiliki simpati"
        HubunganCancer = "Mereka juga berhati-hati ketika harus menunjukkan emosi mereka kepada pasangan cinta, karena mereka ingin menghindari sakit hati dengan cara apa pun. Demikian pula, begitu berhubungan, mereka akan memastikan bahwa mereka tidak menyakiti pasangannya dengan cara apa pun."
        EmosiCancer = "Biasanya akan mulai menyindir halus orang yang telah berani memancing amarahnya. Namun, jika orang itu tidak segera sadar akan kesalahannya, Cancer akan mulai melayangkan kemarahannya secara terang-terangan."

        'Zodiak Leo
        SifatLeo = "Dermawan dan loyal"
        HubunganLeo = "Mereka suka bergerak dengan cepat dan suka dihargai atas usahanya. Mungkin sulit untuk memenuhi harapan mereka. Leo mungkin merasa sulit untuk puas dengan satu orang."
        EmosiLeo = "Mereka tak akan segan untuk memaki, berteriak, dan bahkan berkata kasar kepada seseorang yang telah berani memancing kemarahannya. Orang-orang yang berada di bawah naungan zodiak Leo, bukanlah sosok yang dapat menyembunyikan kemarahannya dengan baik."

        'Zodiak Virgo
        SifatVirgo = "Rajin dan sederhana"
        HubunganVirgo = "Mereka mungkin tidak memberikan cukup waktu untuk hubungan, bahkan jika mereka tertarik kepada seseorang. Sebagai pasangan, Anda membutuhkan kesabaran yang luar biasa untuk menghadapi Virgo."
        EmosiVirgo = "lebih suka memendam segala bentuk emosi yang sedang dia rasakan yang membuat Virgo menjadi sosok yang mudah merasa bad mood dan semakin memperkeruh suasana hatinya."

        'Zodiak Libra
        SifatLibra = "Stabil dan senang menolong"
        HubunganLibra = "Mereka cenderung jatuh cinta dengan cepat dan memiliki pemahaman bawaan untuk menjaga hubungan tetap berjalan. Mereka, bagaimanapun, tidak terlalu diplomatis dalam hal mengelola pasang surut dalam suatu hubungan."
        EmosiLibra = "Ketika sedang merasa marah, maka mereka biasanya tidak akan menunjukkan kemarahannya di depan banyak orang. Mereka lebih memilih untuk diam sejenak dan menenangkan hatinya demi menjaga nama baik yang dimilikinya."

        'Zodiak Scorpio
        SifatScorpio = "Pantang menyerah dan tidak pelit"
        HubunganScorpio = "Begitu mereka memberikan komitmen mereka kepada seseorang, mereka tidak akan pernah berhenti, bahkan jika itu menyakiti mereka. Mereka juga sangat misterius. Artinya mereka bisa menyembunyikan rasa sakit dari pasangannya. Mereka mencari keamanan emosional pada pasangannya."
        EmosiScorpio = "Tidak mudah merasa marah namun, sekalinya mereka merasa marah dan kecewa, maka biasanya Scorpio tidak akan segan untuk mengomel dan mencaci maki hingga perasaannya menjadi puas. Mereka juga bukan sosok yang mudah memaafkan kesalahan seseorang. Jadi, kamu wajib hati-hati ya kalau ingin mencari gara-gara dengannya."

        'Zodiak Sagitarius
        SifatSagitarius = "Jujur dan berwawasan luas"
        HubunganSagitarius = "Kepribadian Sagitarius tetap. Mereka tidak suka berubah untuk apa pun sampai mereka menginginkannya. Mereka mencintai kebebasan mereka dan membencinya ketika tanggung jawab mereka meningkat. Sulit untuk mengenal dan menanganinya."
        EmosiSagitarius = "Bukan hanya tak segan untuk memarahimu, namun mereka juga tak ragu untuk menghapusmu dari daftar pertemanannya. Sekali mereka merasa kecewa, maka mereka akan terus selalu mengingatnya dan tak akan pernah melupakannya."

        If Bulan2 = "Januari" And Tanggal2 <= 19 Then
            TXT_Sifat.Text = SifatCapricorn
            TXT_Hubungan.Text = HubunganCapricorn
            TXT_Emosi.Text = EmosiCapricorn
            PB_Zodiak.Image = My.Resources.Capricorn
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "Januari" And Tanggal2 = 20 >= 31 Then
            TXT_Sifat.Text = SifatAquarius
            TXT_Hubungan.Text = HubunganAquarius
            TXT_Emosi.Text = EmosiAquarius
            PB_Zodiak.Image = My.Resources.Aquarius
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "Februari" And Tanggal2 = 30 >= 31 Then
            MessageBox.Show("Pada bulan Februari tidak ada tanggal itu ka :)")
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "Februari" And Tanggal2 = 1 >= 18 Then
            TXT_Sifat.Text = SifatAquarius
            TXT_Hubungan.Text = HubunganAquarius
            TXT_Emosi.Text = EmosiAquarius
            PB_Zodiak.Image = My.Resources.Aquarius
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "Februari" And Tanggal2 = 19 >= 29 Then
            TXT_Sifat.Text = SifatPisces
            TXT_Hubungan.Text = HubunganPisces
            TXT_Emosi.Text = EmosiPisces
            PB_Zodiak.Image = My.Resources.Pisces
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "Maret" And Tanggal2 = 1 >= 20 Then
            TXT_Sifat.Text = SifatPisces
            TXT_Hubungan.Text = HubunganPisces
            TXT_Emosi.Text = EmosiPisces
            PB_Zodiak.Image = My.Resources.Pisces
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "Maret" And Tanggal2 = 21 >= 31 Then
            TXT_Sifat.Text = SifatAries
            TXT_Hubungan.Text = HubunganAries
            TXT_Emosi.Text = EmosiAries
            PB_Zodiak.Image = My.Resources.Aries
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "April" And Tanggal2 <= 19 Then
            TXT_Sifat.Text = SifatAries
            TXT_Hubungan.Text = HubunganAries
            TXT_Emosi.Text = EmosiAries
            PB_Zodiak.Image = My.Resources.Aries
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "April" And Tanggal2 = 20 >= 30 Then
            TXT_Sifat.Text = SifatTaurus
            TXT_Hubungan.Text = HubunganTaurus
            TXT_Emosi.Text = EmosiTaurus
            PB_Zodiak.Image = My.Resources.Taurus
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "Mei" And Tanggal2 = 1 >= 20 Then
            TXT_Sifat.Text = SifatTaurus
            TXT_Hubungan.Text = HubunganTaurus
            TXT_Emosi.Text = EmosiTaurus
            PB_Zodiak.Image = My.Resources.Taurus
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "Mei" And Tanggal2 = 21 >= 31 Then
            TXT_Sifat.Text = SifatGemini
            TXT_Hubungan.Text = HubunganGemini
            TXT_Emosi.Text = EmosiGemini
            PB_Zodiak.Image = My.Resources.Gemini
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "Juni" And Tanggal2 <= 20 Then
            TXT_Sifat.Text = SifatGemini
            TXT_Hubungan.Text = HubunganGemini
            TXT_Emosi.Text = EmosiGemini
            PB_Zodiak.Image = My.Resources.Gemini
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "Juni" And Tanggal2 = 21 >= 30 Then
            TXT_Sifat.Text = SifatCancer
            TXT_Hubungan.Text = HubunganCancer
            TXT_Emosi.Text = EmosiCancer
            PB_Zodiak.Image = My.Resources.Cancer
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "Juli" And Tanggal2 <= 22 Then
            TXT_Sifat.Text = SifatCancer
            TXT_Hubungan.Text = HubunganCancer
            TXT_Emosi.Text = EmosiCancer
            PB_Zodiak.Image = My.Resources.Cancer
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "Juli" And Tanggal2 = 23 >= 31 Then
            TXT_Sifat.Text = SifatLeo
            TXT_Hubungan.Text = HubunganLeo
            TXT_Emosi.Text = EmosiLeo
            PB_Zodiak.Image = My.Resources.Leo
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "Agustus" And Tanggal2 <= 22 Then
            TXT_Sifat.Text = SifatLeo
            TXT_Hubungan.Text = HubunganLeo
            TXT_Emosi.Text = EmosiLeo
            PB_Zodiak.Image = My.Resources.Leo
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "Agustus" And Tanggal2 = 23 >= 31 Then
            TXT_Sifat.Text = SifatVirgo
            TXT_Hubungan.Text = HubunganVirgo
            TXT_Emosi.Text = EmosiVirgo
            PB_Zodiak.Image = My.Resources.Virgo
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "September" And Tanggal2 <= 22 Then
            TXT_Sifat.Text = SifatVirgo
            TXT_Hubungan.Text = HubunganVirgo
            TXT_Emosi.Text = EmosiVirgo
            PB_Zodiak.Image = My.Resources.Virgo
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "September" And Tanggal2 = 23 >= 30 Then
            TXT_Sifat.Text = SifatLibra
            TXT_Hubungan.Text = HubunganLibra
            TXT_Emosi.Text = EmosiLibra
            PB_Zodiak.Image = My.Resources.Libra
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "Oktober" And Tanggal2 <= 22 Then
            TXT_Sifat.Text = SifatLibra
            TXT_Hubungan.Text = HubunganLibra
            TXT_Emosi.Text = EmosiLibra
            PB_Zodiak.Image = My.Resources.Libra
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "Oktober" And Tanggal2 = 23 >= 31 Then
            TXT_Sifat.Text = SifatScorpio
            TXT_Hubungan.Text = HubunganScorpio
            TXT_Emosi.Text = EmosiScorpio
            PB_Zodiak.Image = My.Resources.Scorpio
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "November" And Tanggal2 <= 21 Then
            TXT_Sifat.Text = SifatScorpio
            TXT_Hubungan.Text = HubunganScorpio
            TXT_Emosi.Text = EmosiScorpio
            PB_Zodiak.Image = My.Resources.Scorpio
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "November" And Tanggal2 = 22 >= 30 Then
            TXT_Sifat.Text = SifatSagitarius
            TXT_Hubungan.Text = HubunganSagitarius
            TXT_Emosi.Text = EmosiSagitarius
            PB_Zodiak.Image = My.Resources.Sagitarius
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "Desember" And Tanggal2 <= 21 Then
            TXT_Sifat.Text = SifatSagitarius
            TXT_Hubungan.Text = HubunganSagitarius
            TXT_Emosi.Text = EmosiSagitarius
            PB_Zodiak.Image = My.Resources.Sagitarius
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
        If Bulan2 = "Desember" And Tanggal2 = 22 >= 31 Then
            TXT_Sifat.Text = SifatCapricorn
            TXT_Hubungan.Text = HubunganCapricorn
            TXT_Emosi.Text = EmosiCapricorn
            PB_Zodiak.Image = My.Resources.Capricorn
            'LBL_Nama.Show()
            'LBL_Pekerjaan.Show()
            'LBL_Status.Show()
        End If
    End Sub

    Private Sub BTN_Reset_Click(sender As Object, e As EventArgs) Handles BTN_Reset.Click
        TXT_Emosi.Text = " "
        TXT_Hubungan.Text = " "
        TXT_Nama.Text = " "
        TXT_Pekerjaan.Text = " "
        TXT_Sifat.Text = " "
        TXT_Status.Text = " "
        PB_Zodiak.Image = Reset()
    End Sub
End Class
'By Habib Fauzan Mahardika 9882405120111014