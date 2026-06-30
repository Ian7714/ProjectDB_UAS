
USE `dbuts__c`;

-- 1. Mengisi data Pengguna (usia > 17 tahun)
INSERT INTO `Pengguna` (`email`, `nama_lengkap`, `nomor_telepon`, `tanggal_lahir`, `dibuat_pada`) VALUES
('fathan@email.com', 'Ahmad Fathan', '08123456789', '1995-05-20', NOW()),
('fernanda@email.com', 'Fernanda Rizky', '08571234567', '2000-10-15', NOW()),
('arsyad@email.com', 'Muhammad Arsyad', '08998765432', '1990-01-01', NOW()),
('raihan@email.com', 'Raihanu', '08112233445', '1988-12-12', NOW()),
('randy@email.com', 'Randibang', '08129988776', '2005-03-25', NOW()),
('thalia@email.com', 'Thaliaas', '08129988777', '2005-05-25', NOW());

-- 2. Mengisi data Resep
INSERT INTO `Resep` (`nama_resep`, `langkah_memasak`, `waktu_memasak`, `jumlah_sajian`, `tingkat_kesulitan`, `versi_resep`) VALUES
('Ayam Goreng Lengkuas', '1. Ungkep ayam dengan lengkuas dan bumbu\n2. Goreng hingga kecoklatan\n3. Sajikan dengan sambal', 45, 4, 'sedang', NULL),
('Ayam Geprek Pedas', '1. Goreng ayam hingga matang\n2. Ulek cabe rawit dan bawang\n3. Geprek ayam dengan sambal', 30, 1, 'mudah', 'Versi tanpa micin'),
('Soto Ayam Lamongan', '1. Rebus ayam dengan bumbu\n2. Tumis bumbu halus\n3. Masukkan ke kuah kaldu\n4. Tambahkan sayuran', 60, 6, 'sulit', NULL),
('Sayur Sop Sehat', '1. Potong sayur-sayuran\n2. Rebus air hingga mendidih\n3. Masukkan sayur dan bumbu', 20, 3, 'mudah', NULL);

-- 3. Mengisi data Postingan
INSERT INTO `Postingan` (`postingan_id`, `teks`, `tanggal_pembuatan`, `jenis_postingan`, `Pengguna_pengguna_id`, `Resep_resep_id`) VALUES
(1, 'Masak ayam goreng hari ini!', NOW(), 'resep', 1, 1),
(2, 'Gepreknya mantap banget!', NOW(), 'resep', 2, 2),
(3, 'Coba bikin soto sendiri di rumah', NOW(), 'resep', 3, 3),
(4, 'Update resep sayur sop keluarga', NOW(), 'resep', 4, 4),
(5, 'Lagi pengen makan enak nih', NOW(), 'biasa', 1, NULL);

-- 4. Mengisi data Bahan
INSERT INTO `Bahan` (`nama_bahan`, `satuan`, `kalori_per_unit`) VALUES
('Ayam', 'Gram', 239),
('Lengkuas', 'Ruas', 10),
('Cabe Rawit', 'Biji', 5),
('Bawang Putih', 'Siung', 4),
('Wortel', 'Batang', 30);

-- 5. Mengisi data Resep_Bahan 
INSERT INTO `Resep_Bahan` (`Bahan_bahan_id`, `Resep_resep_id`, `jumlah`) VALUES
(1, 1, 500.00), -- Ayam di resep 1
(2, 1, 2.00),   -- Lengkuas di resep 1
(1, 2, 250.00), -- Ayam di resep 2
(3, 2, 10.00);  -- Cabe di resep 2

-- 6. Mengisi data Kategori
INSERT INTO `Kategori` (`nama_kategori`) VALUES
('Makanan Utama'), ('Tradisional'), ('Pedas'), ('Sehat');

-- 7. Mengisi data Resep_Kategori
INSERT INTO `Resep_Kategori` (`Resep_resep_id`, `Kategori_kategori_id`) VALUES
(1, 1), (1, 2), (2, 1), (2, 3);

-- 8. Mengisi data Kolaborasi_Resep
INSERT INTO `Kolaborasi_Resep` (`peran`, `Resep_resep_id`, `Pengguna_pengguna_id`) VALUES
('pembuat', 3, 3),
('kontributor', 3, 4);

-- 9. Mengisi data Interaksi 
INSERT INTO `Interaksi` (`tipe`, `tanggal_interaksi`, `teks_komentar`, `Postingan_postingan_id`, `Pengguna_pengguna_id`) VALUES
('suka', NOW(), NULL, 1, 2),
('simpan', NOW(), NULL, 1, 3),
('komentar', NOW(), 'Kelihatannya enak!', 1, 4),
('bagikan', NOW(), NULL, 2, 1),
('simpan', NOW(), NULL, 3, 1);

-- 10. Mengisi data Recook
INSERT INTO `Recook` (`tanggal_percobaan`, `hasil`, `Pengguna_pengguna_id`, `status_baca`, `Resep_resep_id`) VALUES
('2026-05-01', 'berhasil', 2, 'sudah dibaca', 1),
('2026-05-02', 'gagal', 3, 'belum', 1),
('2026-05-03', 'berhasil', 1, 'sudah dibaca', 2);

-- 11. Mengisi data Mengikuti (Follow)
INSERT INTO `Mengikuti` (`pengikut_id`, `diikuti_id`) VALUES
(1, 4), (2, 4), (3, 4), (4, 1), (5, 4);

-- 12. Mengisi data Daftar_Bacaan (Reading_List)
INSERT INTO `Daftar_Bacaan` (`Pengguna_pengguna_id`, `Postingan_postingan_id`, `nama_daftar`) VALUES
(1, 1, 'Resep Ayam Favorit'),
(2, 1, 'Resep Ayam Favorit'),
(3, 1, 'Resep Ayam Favorit'),
(4, 1, 'Resep Ayam Favorit'),
(5, 1, 'Resep Ayam Favorit'),
(1, 3, 'Masakan Berkuah'),
(6, 1, 'Resep Ayam Favorit');

-- 13. Mengisi data Pencarian
INSERT INTO `Pencarian` (`kata_kunci`, `tanggal_pencarian`, `Pengguna_pengguna_id`) VALUES
('ayam goreng', NOW(), 1),
('soto', DATE_SUB(NOW(), INTERVAL 5 DAY), 2),
('sop sehat', DATE_SUB(NOW(), INTERVAL 20 DAY), 3);

-- 14. Mengisi data Gambar 
INSERT INTO `Gambar` (`url_gambar`, `urutan`, `Postingan_postingan_id`) VALUES
('http://cloud.storage/ayam_goreng_1.jpg', 1, 1),
('http://cloud.storage/ayam_goreng_detail.jpg', 2, 1),
('http://cloud.storage/geprek.png', 1, 2),
('http://cloud.storage/soto_lamongan.jpg', 1, 3);

-- 15. Mengisi data Rating
INSERT INTO `Rating` (`skor_rating`, `Pengguna_pengguna_id`, `Resep_resep_id`) VALUES
(5, 2, 1),
(4, 3, 1),
(5, 1, 2),
(3, 4, 3);

-- 16. Mengisi data Ulasan (Review)
INSERT INTO `Ulasan` (`isi_ulasan`, `tanggal_ulasan`, `Resep_resep_id`, `Pengguna_pengguna_id`) VALUES
('Rasanya pas banget, bumbunya meresap!', NOW(), 1, 2),
('Gampang diikuti langkah-langkahnya.', NOW(), 1, 3),
('Terlalu pedas untuk saya tapi enak.', NOW(), 2, 1);

-- 17. Mengisi data Pencarian tambahan
INSERT INTO `Pencarian` (`kata_kunci`, `tanggal_pencarian`, `Pengguna_pengguna_id`) VALUES
('nasi goreng', '2026-04-28 10:00:00', 4),
('rendang sapi', '2026-05-01 14:30:00', 1),
('sambal bawang', '2026-05-03 09:15:00', 2);

-- 18. Mengisi data Tantangan_Memasak
INSERT INTO `Tantangan_Memasak` (`nama_tantangan`, `deskripsi`, `tanggal_mulai`, `tanggal_selesai`, `hadiah`) VALUES
('Ramadhan Berkah', 'Masak takjil sehat untuk berbuka', '2026-03-01', '2026-03-31', 'Voucher Belanja 500rb'),
('Sarapan Cepat', 'Resep sarapan praktis kurang dari 15 menit', '2026-04-15', '2026-05-15', 'Set Pisau Dapur'),
('Kreasi Ayam Nusantara', 'Inovasi masakan ayam khas daerah', '2026-05-01', '2026-05-30', 'Panci Presto');

-- 19. Mengisi data Peserta_Tantangan
INSERT INTO `Peserta_Tantangan` (`Tantangan_Memasak_tantangan_id`, `tanggal_ikut`, `Pengguna_pengguna_id`, `Postingan_postingan_id`) VALUES
(1, '2026-03-10 08:00:00', 1, 1), 
(2, '2026-04-20 10:00:00', 2, 2), 
(3, '2026-05-02 12:00:00', 3, 3), 
(3, '2026-05-03 15:30:00', 4, 4);

-- 20. Mengisi data Papan_Peringkat (Leaderboard)
INSERT INTO `Papan_Peringkat` (`periode`, `skor_pengaruh`, `kategori`, `Pengguna_pengguna_id`, `Interaksi_interaksi_id`, `Interaksi_Postingan_postingan_id`, `Interaksi_Pengguna_pengguna_id`) VALUES('2026-05-01', 150, 'paling berpengaruh', 4, 3, 1, 4), 
('2026-05-01', 85, 'paling disukai', 1, 1, 1, 2),   
('2026-05-01', 120, 'paling banyak direcook', 2, 2, 1, 3);

-- 21. Mengisi data Rencana_Menu
INSERT INTO `Rencana_Menu` (`nama_rencana`, `deskripsi`, `tanggal_mulai`, `tanggal_selesai`, `publik`, `dibuat_pada`, `Pengguna_pengguna_id`) VALUES
('Menu Sehat Seminggu', 'Rencana menu sehat untuk keluarga', '2026-05-01', '2026-05-07', TRUE, NOW(), 1),
('Menu Hemat Bulanan', 'Menu ekonomis untuk 4 orang', '2026-05-15', '2026-05-21', FALSE, NOW(), 2),
('Menu Diet Sehat', 'Rencana menu rendah kalori', '2026-06-01', '2026-06-07', TRUE, NOW(), 3),
('Menu Keluarga', 'Menu favorit keluarga besar', '2026-05-10', '2026-05-16', FALSE, NOW(), 4);

-- 22. Mengisi data Detail_Rencana_Menu
INSERT INTO `Detail_Rencana_Menu` (`tanggal`, `jenis_makanan`, `catatan`, `Rencana_Menu_rencana_menu_id`, `Resep_resep_id`) VALUES
-- Menu Sehat Seminggu (rencana_menu_id = 1)
('2026-05-01', 'sarapan', 'Sarapan sehat', 1, 4),
('2026-05-01', 'makan_siang', 'Makan siang', 1, 3),
('2026-05-01', 'makan_malam', 'Makan malam', 1, 1),
('2026-05-02', 'sarapan', 'Sarapan', 1, 4),
('2026-05-02', 'makan_siang', 'Menu siang', 1, 1),
('2026-05-02', 'makan_malam', 'Menu malam', 1, 2),

-- Menu Hemat Bulanan (rencana_menu_id = 2)
('2026-05-15', 'sarapan', 'Sarapan praktis', 2, 4),
('2026-05-15', 'makan_siang', 'Menu simpel', 2, 3),
('2026-05-15', 'makan_malam', 'Menu irit', 2, 1),

-- Menu Diet Sehat (rencana_menu_id = 3)
('2026-06-01', 'sarapan', 'Rendah kalori', 3, 4),
('2026-06-01', 'makan_siang', 'Diet', 3, 3),
('2026-06-01', 'makan_malam', 'Makan malam diet', 3, 4),
('2026-06-01', 'camilan', 'Camilan sehat', 3, 4);

-- 23. Mengisi data Rencana_Menu_Dibagikan
INSERT INTO `Rencana_Menu_Dibagikan` (`Rencana_Menu_rencana_menu_id`, `Pengguna_pengguna_id`, `tanggal_dibagikan`, `status`) VALUES
(1, 2, NOW(), 'diterima'),    -- Rencana menu 1 dibagikan ke pengguna 2, diterima
(1, 3, NOW(), 'menunggu'),    -- Rencana menu 1 dibagikan ke pengguna 3, menunggu
(1, 4, NOW(), 'ditolak'),     -- Rencana menu 1 dibagikan ke pengguna 4, ditolak
(2, 1, NOW(), 'diterima'),    -- Rencana menu 2 dibagikan ke pengguna 1, diterima
(3, 5, NOW(), 'menunggu'),    -- Rencana menu 3 dibagikan ke pengguna 5, menunggu
(4, 2, NOW(), 'diterima');    -- Rencana menu 4 dibagikan ke pengguna 2, diterima