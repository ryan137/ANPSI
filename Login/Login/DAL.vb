Imports MySql.Data.MySqlClient
Public Class DAL

    Public Function login(ByVal user As String, ByVal pass As String) As String
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "select user_akses from user where user_name = '" & user & "' and user_pass='" & pass & "'"
        Dim akses As String
        akses = command.ExecuteScalar
        closeconnection()
        Return akses
    End Function

    Public Function insertjurusan(ByVal nama As String, ByVal kode As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "insert into jurusan values('','" & nama & "','" & kode & "')"
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Return "sukse insert"
        Else
            closeconnection()
            Return "gagal insert"
        End If
    End Function

    Public Function updatejurusan(ByVal id As String, ByVal nama As String, ByVal kode As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "update jurusan set jurusan_nama='" & nama & "', jurusan_kode = '" & kode & "' where jurusan_id ='" & id & "'"
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Return "sukses update"
        Else
            closeconnection()
            Return "gagal update"
        End If
    End Function

    Public Function deletejurusan(ByVal id As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "delete from jurusan where jurusan_id='" & id & "' "
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Return "sukses hapus"
        Else
            closeconnection()
            Return "gagal hapus"
        End If
    End Function

    Public Function getjurusan(ByVal id As String)
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select * from jurusan where jurusan_id ='" & id & "'"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function getalljurusan()
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select jurusan_id ,jurusan_nama as Nama , jurusan_kode as Kode from jurusan"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function getalluser()
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select user_id, user_name as NamaPengguna, user_pass as Password, user_akses as Akses from user"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function insertuser(ByVal username As String, ByVal password As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "insert into user values('','" & username & "','" & password & "', 'admin')"
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Return "sukses insert"
        Else
            closeconnection()
            Return "gagal insert"
        End If
    End Function


    Public Function getallbeasiswa()
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select * from beasiswa "
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function insertbeasiswa(ByVal nama As String, ByVal bpp As String, ByVal sks As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()

        command.CommandText = "insert into beasiswa values('','" & nama & "','" & bpp & "','" & sks & "')"
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Return "Sukses insert"
        Else
            closeconnection()
            Return "gagal insert"
        End If
    End Function

    Public Function getbeasiswa(ByVal id As String)
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select * from beasiswa where beasiswa_id ='" & id & "'"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function updatebeasiwa(ByVal id As String, ByVal nama As String, ByVal bpp As String, ByVal sks As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()

        command.CommandText = "update beasiswa set beasiswa_nama='" & nama & "', beasiswa_bpp='" & bpp & "', beasiswa_sks = '" & sks & "' where beasiswa_id = '" & id & "'"
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Return "Sukses update"
        Else
            closeconnection()
            Return "gagal update"
        End If
    End Function

    Public Function deletebeasiswa(ByVal id As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "delete from beasiswa where beasiswa_id ='" & id & "'"
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Return "Sukses hapus"
        Else
            closeconnection()
            Return "gagal hapus"
        End If
    End Function


    Public Function getallsekolah()
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "select sekolah_id, sekolah_nama as 'Nama Sekolah', sekolah_alamat as 'Alamat Sekolah' from sekolah"
        Dim adp As New MySqlDataAdapter(command)
        Dim data As New DataSet
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function getsekolah(ByVal id As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "select sekolah_id, sekolah_nama as 'Nama Sekolah', sekolah_alamat as 'Alamat Sekolah' from sekolah where sekolah_id = '" & id & "'"
        Dim adp As New MySqlDataAdapter(command)
        Dim data As New DataSet
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function getallwali()
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select wali_id, ayah_nama as 'Nama Ayah',ibu_nama as 'Nama Ibu' , wali_nama as 'Nama Wali' from wali "
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function getwali(ByVal id As String)
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select * from wali where wali_id='" & id & "'"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function getmahasiswa(ByVal id As String)
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select * from mahasiswa where mahasiswa_id='" & id & "'"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function getnilai(id)
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select * from nilai where mahasiswa_id = '" & id & "'"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function insertmahasiswa(mahasiswa, wali, asalsekolah, nilai, jurusan)
        Dim idsekolah, idwali, idmahasiswa As String
        Dim data As New DataSet
        Dim command As New MySqlCommand
        If asalsekolah.GetType() Is GetType(DataSet) Then
            data = asalsekolah
            command.Connection = openconnection()
            command.CommandText = "insert into sekolah values('','" & data.Tables(0).Rows(0).Item("Nama Sekolah") & "','" & data.Tables(0).Rows(0).Item("Alamat Sekolah") & "');select last_insert_id()"
            idsekolah = command.ExecuteScalar()
            closeconnection()
        Else
            idsekolah = wali
        End If



        If wali.GetType() Is GetType(DataSet) Then
            data = wali
            command.Connection = openconnection()
            command.CommandText = "insert into wali values('','" & data.Tables(0).Rows(0).Item("ayah_nama") & "','" & data.Tables(0).Rows(0).Item("ayah_tempatlahir") & "','" & Format(data.Tables(0).Rows(0).Item("ayah_tanggallahir"), "yyyy/MM/dd") & "','" & data.Tables(0).Rows(0).Item("ayah_pekerjaan") & "','" & data.Tables(0).Rows(0).Item("ayah_alamat") & "','" & data.Tables(0).Rows(0).Item("ayah_nohp") & "','" & data.Tables(0).Rows(0).Item("ibu_nama") & "','" & data.Tables(0).Rows(0).Item("ibu_tempatlahir") & "','" & Format(data.Tables(0).Rows(0).Item("ibu_tanggallahir"), "yyyy/MM/dd") & "','" & data.Tables(0).Rows(0).Item("ibu_pekerjaan") & "','" & data.Tables(0).Rows(0).Item("ibu_alamat") & "','" & data.Tables(0).Rows(0).Item("ibu_nohp") & "','" & data.Tables(0).Rows(0).Item("wali_nama") & "','" & data.Tables(0).Rows(0).Item("wali_tempatlahir") & "','" & data.Tables(0).Rows(0).Item("wali_tanggallahir") & "','" & data.Tables(0).Rows(0).Item("wali_pekerjaan") & "','" & data.Tables(0).Rows(0).Item("wali_alamat") & "','" & data.Tables(0).Rows(0).Item("wali_nohp") & "');select last_insert_id()"
            idwali = command.ExecuteScalar
            closeconnection()
        Else
            idwali = wali
        End If


        If idsekolah IsNot Nothing And idwali IsNot Nothing Then
            data = mahasiswa
            command.Connection = openconnection()
            command.CommandText = "insert into mahasiswa values('','" & data.Tables(0).Rows(0).Item("mahasiswa_nama") & "','" & data.Tables(0).Rows(0).Item("mahasiswa_tempatlahir") & "','" & Format(data.Tables(0).Rows(0).Item("mahasiswa_tanggallahir"), "yyyy/MM/dd") & "','" & data.Tables(0).Rows(0).Item("mahasiswa_jeniskelamin") & "','" & data.Tables(0).Rows(0).Item("mahasiswa_alamat") & "','" & data.Tables(0).Rows(0).Item("mahasiswa_nohp") & "','" & data.Tables(0).Rows(0).Item("mahasiswa_email") & "','" & idwali & "','" & idsekolah & "','" & jurusan & "','','" & Format(DateTime.Now, "yyyy/MM/dd") & "','Daftar');select last_insert_id()"
            idmahasiswa = command.ExecuteScalar
            closeconnection()
            If idmahasiswa IsNot Nothing Then
                data = nilai
                command.Connection = openconnection()
                command.CommandText = "insert into nilai values('" & idmahasiswa & "','" & data.Tables(0).Rows(0).Item("nilai_mtk") & "','" & data.Tables(0).Rows(0).Item("nilai_bind") & "','" & data.Tables(0).Rows(0).Item("nilai_bing") & "','" & data.Tables(0).Rows(0).Item("nilai_jurusan") & "')"

                If command.ExecuteNonQuery() > 0 Then
                    closeconnection()
                    Return "insert berhasil"
                Else
                    Return "gagal insert nilai"
                End If
            Else
                Return "Gagal Insert mahasiswa"
            End If
        Else
            Return "gagal insert wali sekolah"
        End If
    End Function

    Public Function getallmahasiswa()
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select a.mahasiswa_id , a.mahasiswa_nama as 'Nama Mahasiswa' , a.mahasiswa_jeniskelamin as 'Jenis Kelamin',b.ayah_nama as 'Nama Ayah',b.ibu_nama as 'Nama Ibu',b.wali_nama as 'Nama Wali',a.tgl_daftar as 'Tanggal Daftar',a.mahasiswa_status as 'Status' from mahasiswa a join wali b on a.wali_id = b.wali_id "
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function getmahasiswaaftertest(ByVal id As String)
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select a.mahasiswa_nama,a.mahasiswa_status,b.beasiswa_nama,b.beasiswa_bpp,b.beasiswa_sks,c.test_nilai from mahasiswa a,beasiswa b, test c where a.mahasiswa_id = c.mahasiswa_id and a.beasiswa_id = b.beasiswa_id and a.mahasiswa_id='" & id & "'"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function getmahasiswanotest()
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select * from mahasiswa where mahasiswa_status = 'Daftar'"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function


    Public Function insertnilaitest(ByVal id As String, ByVal nilai As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "insert into test values('" & id & "','" & nilai & "')"
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Dim status As String
            Dim idbeasiswa As String
            If nilai > 70 Then
                status = "Lolos"
                If nilai > 70 And nilai < 81 Then
                    idbeasiswa = "13"
                ElseIf nilai > 80 And nilai < 91 Then
                    idbeasiswa = "12"
                ElseIf nilai > 90 Then
                    idbeasiswa = "11"
                Else
                    idbeasiswa = "14"
                End If
                command.Connection = openconnection()
                command.CommandText = "update mahasiswa set mahasiswa_status='" & status & "',beasiswa_id=" & idbeasiswa & " where mahasiswa_id='" & id & "'"
                If command.ExecuteNonQuery > 0 Then
                    closeconnection()
                    Return "sukses"
                Else
                    closeconnection()
                    Return "gagal"
                End If
            Else
                status = "Gagal"
                command.Connection = openconnection()
                command.CommandText = "update mahasiswa set mahasiswa_status='" & status & "',beasiswa_id=null where mahasiswa_id='" & id & "'"
                If command.ExecuteNonQuery > 0 Then
                    closeconnection()
                    Return "sukses"
                Else
                    closeconnection()
                    Return "gagal"
                End If

            End If
        Else
            closeconnection()
            Return "gagal"
        End If
    End Function


    Public Function getalltest()
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        command.Connection = openconnection()
        command.CommandText = "select a.mahasiswa_id,a.mahasiswa_nama,b.test_nilai from mahasiswa a join test b on a.mahasiswa_id = b.mahasiswa_id"
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function


    Public Function searchtest(ByVal nama As String, ByVal id As String)
        Dim command As New MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim data As New DataSet
        Dim a As String = "select a.mahasiswa_id,a.mahasiswa_nama,b.test_nilai from mahasiswa a join test b on a.mahasiswa_id = b.mahasiswa_id where"
        command.Connection = openconnection()
        If nama <> "" Then
            a += " a.mahasiswa_nama like '" & nama & "%'"
        End If
        If id <> "" Then
            a += " a.mahasiswa_id = '" & id & "'"
        End If
        command.CommandText = a
        adp = New MySqlDataAdapter(command)
        adp.Fill(data)
        closeconnection()
        Return data
    End Function

    Public Function EditNilaiTest(ByVal id As String, ByVal nilai As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "update test set test_nilai = '" & nilai & "' where mahasiswa_id=" & id
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            Dim status As String
            Dim idbeasiswa As String
            If nilai > 70 Then
                status = "Lolos"
                If nilai > 70 And nilai < 81 Then
                    idbeasiswa = "13"
                ElseIf nilai > 80 And nilai < 91 Then
                    idbeasiswa = "12"
                ElseIf nilai > 90 Then
                    idbeasiswa = "11"
                Else
                    idbeasiswa = "14"
                End If

                command.Connection = openconnection()
                command.CommandText = "update mahasiswa set mahasiswa_status='" & status & "',beasiswa_id=" & idbeasiswa & " where mahasiswa_id=" & id
                If command.ExecuteNonQuery > 0 Then
                    closeconnection()
                    Return "sukses"
                Else
                    closeconnection()
                    Return "gagal"
                End If
            Else
                status = "Gagal"
                command.Connection = openconnection()
                command.CommandText = "update mahasiswa set mahasiswa_status='" & status & "',beasiswa_id=null where mahasiswa_id=" & id
                If command.ExecuteNonQuery > 0 Then
                    closeconnection()
                    Return "sukses"
                Else
                    closeconnection()
                    Return "gagal"
                End If
            End If
            command.Connection = openconnection()
            command.CommandText = "update mahasiswa set mahasiswa_status='" & status & "',beasiswa_id=" & idbeasiswa & " where mahasiswa_id=" & id
            If command.ExecuteNonQuery > 0 Then
                closeconnection()
                Return "sukses"
            Else
                closeconnection()
                Return "gagal"
            End If
        Else
            closeconnection()
            Return "gagal"
        End If
    End Function

    Public Function deletetestnilai(ByVal id As String)
        Dim command As New MySqlCommand
        command.Connection = openconnection()
        command.CommandText = "delete from test where mahasiswa_id =" & id
        If command.ExecuteNonQuery > 0 Then
            closeconnection()
            command.CommandText = "update mahasiswa set beasiswa_id=null ,mahasiswa_status ='Daftar' where mahasiswa_id='" & id & "'"
            If command.ExecuteNonQuery > 0 Then
                closeconnection()
                Return "sukses"
            Else
                closeconnection()
                Return "gagal"
            End If
        Else
            closeconnection()
            Return "gagal"
        End If
    End Function

End Class
