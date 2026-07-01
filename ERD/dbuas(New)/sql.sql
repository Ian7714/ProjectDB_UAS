-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema dbuts_c
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema dbuts_c
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `dbuts_c` DEFAULT CHARACTER SET utf8mb4 ;
-- -----------------------------------------------------
-- Schema dbuts__c
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema dbuts__c
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `dbuts__c` DEFAULT CHARACTER SET utf8mb4 ;
USE `dbuts_c` ;

-- -----------------------------------------------------
-- Table `dbuts_c`.`bahan`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts_c`.`bahan` (
  `bahan_id` INT(11) NOT NULL AUTO_INCREMENT,
  `nama_bahan` VARCHAR(100) NULL DEFAULT NULL,
  `satuan` VARCHAR(50) NULL DEFAULT NULL,
  `kalori_per_unit` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`bahan_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts_c`.`gambar`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts_c`.`gambar` (
  `gambar_id` INT(11) NOT NULL AUTO_INCREMENT,
  `url_gambar` VARCHAR(255) NULL DEFAULT NULL,
  `urutan` INT(11) NULL DEFAULT NULL,
  `Postingan_postingan_id` INT(11) NOT NULL,
  PRIMARY KEY (`gambar_id`),
  INDEX `fk_Gambar_Postingan1_idx` (`Postingan_postingan_id` ASC) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts_c`.`interaksi`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts_c`.`interaksi` (
  `interaksi_id` INT(11) NOT NULL AUTO_INCREMENT,
  `tipe` ENUM('suka', 'simpan', 'bagikan', 'komentar') NULL DEFAULT NULL,
  `tanggal_interaksi` DATETIME NULL DEFAULT NULL,
  `teks_komentar` TEXT NULL DEFAULT NULL,
  `Postingan_postingan_id` INT(11) NOT NULL,
  `Pengguna_pengguna_id` INT(11) NOT NULL,
  PRIMARY KEY (`interaksi_id`, `Postingan_postingan_id`, `Pengguna_pengguna_id`),
  INDEX `fk_Interaksi_Postingan1_idx` (`Postingan_postingan_id` ASC) ,
  INDEX `fk_Interaksi_Pengguna1_idx` (`Pengguna_pengguna_id` ASC) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts_c`.`kategori`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts_c`.`kategori` (
  `kategori_id` INT(11) NOT NULL AUTO_INCREMENT,
  `nama_kategori` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`kategori_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts_c`.`kolaborasi_resep`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts_c`.`kolaborasi_resep` (
  `peran` ENUM('pembuat', 'kontributor') NULL DEFAULT NULL,
  `Resep_resep_id` INT(11) NOT NULL,
  `Pengguna_pengguna_id` INT(11) NOT NULL,
  PRIMARY KEY (`Resep_resep_id`, `Pengguna_pengguna_id`),
  INDEX `fk_Kolaborasi_Resep_Resep1_idx` (`Resep_resep_id` ASC) ,
  INDEX `fk_Kolaborasi_Resep_Pengguna1_idx` (`Pengguna_pengguna_id` ASC) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts_c`.`pengguna`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts_c`.`pengguna` (
  `pengguna_id` INT(11) NOT NULL AUTO_INCREMENT,
  `email` VARCHAR(100) NOT NULL,
  `nama_lengkap` VARCHAR(100) NOT NULL,
  `nomor_telepon` VARCHAR(15) NOT NULL,
  `tanggal_lahir` DATE NOT NULL,
  `dibuat_pada` DATETIME NULL DEFAULT NULL,
  PRIMARY KEY (`pengguna_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts_c`.`postingan`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts_c`.`postingan` (
  `postingan_id` INT(11) NOT NULL,
  `teks` TEXT NULL DEFAULT NULL,
  `tanggal_pembuatan` DATETIME NULL DEFAULT NULL,
  `jenis_postingan` ENUM('biasa', 'resep') NULL DEFAULT NULL,
  `Pengguna_pengguna_id` INT(11) NOT NULL,
  `Resep_resep_id` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`postingan_id`),
  INDEX `fk_Postingan_Pengguna_idx` (`Pengguna_pengguna_id` ASC) ,
  INDEX `fk_Postingan_Resep1_idx` (`Resep_resep_id` ASC) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts_c`.`resep`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts_c`.`resep` (
  `resep_id` INT(11) NOT NULL AUTO_INCREMENT,
  `nama_resep` VARCHAR(200) NOT NULL,
  `langkah_memasak` TEXT NULL DEFAULT NULL,
  `waktu_memasak` INT(11) NULL DEFAULT NULL,
  `jumlah_sajian` INT(11) NULL DEFAULT NULL,
  `tingkat_kesulitan` ENUM('mudah', 'sedang', 'sulit') NULL DEFAULT NULL,
  `versi_resep` TEXT NULL DEFAULT NULL,
  PRIMARY KEY (`resep_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;

USE `dbuts__c` ;

-- -----------------------------------------------------
-- Table `dbuts__c`.`bahan`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`bahan` (
  `bahan_id` INT(11) NOT NULL AUTO_INCREMENT,
  `nama_bahan` VARCHAR(100) NULL DEFAULT NULL,
  `satuan` VARCHAR(50) NULL DEFAULT NULL,
  `kalori_per_unit` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`bahan_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`pengguna`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`pengguna` (
  `pengguna_id` INT(11) NOT NULL AUTO_INCREMENT,
  `email` VARCHAR(100) NOT NULL,
  `nama_lengkap` VARCHAR(100) NOT NULL,
  `nomor_telepon` VARCHAR(15) NOT NULL,
  `tanggal_lahir` DATE NOT NULL,
  `dibuat_pada` DATETIME NULL DEFAULT NULL,
  `sandi` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`pengguna_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`resep`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`resep` (
  `resep_id` INT(11) NOT NULL AUTO_INCREMENT,
  `nama_resep` VARCHAR(200) NOT NULL,
  `langkah_memasak` TEXT NULL DEFAULT NULL,
  `waktu_memasak` INT(11) NULL DEFAULT NULL,
  `jumlah_sajian` INT(11) NULL DEFAULT NULL,
  `tingkat_kesulitan` ENUM('mudah', 'sedang', 'sulit') NULL DEFAULT NULL,
  `versi_resep` TEXT NULL DEFAULT NULL,
  PRIMARY KEY (`resep_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`postingan`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`postingan` (
  `postingan_id` INT(11) NOT NULL,
  `teks` TEXT NULL DEFAULT NULL,
  `tanggal_pembuatan` DATETIME NULL DEFAULT NULL,
  `jenis_postingan` ENUM('biasa', 'resep') NULL DEFAULT NULL,
  `Pengguna_pengguna_id` INT(11) NOT NULL,
  `Resep_resep_id` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`postingan_id`),
  INDEX `fk_Postingan_Pengguna_idx` (`Pengguna_pengguna_id` ASC) ,
  INDEX `fk_Postingan_Resep1_idx` (`Resep_resep_id` ASC) ,
  CONSTRAINT `fk_Postingan_Pengguna`
    FOREIGN KEY (`Pengguna_pengguna_id`)
    REFERENCES `dbuts__c`.`pengguna` (`pengguna_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Postingan_Resep1`
    FOREIGN KEY (`Resep_resep_id`)
    REFERENCES `dbuts__c`.`resep` (`resep_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`daftar_bacaan`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`daftar_bacaan` (
  `Pengguna_pengguna_id` INT(11) NOT NULL,
  `Postingan_postingan_id` INT(11) NOT NULL,
  `nama_daftar` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`Pengguna_pengguna_id`, `Postingan_postingan_id`),
  INDEX `fk_Pengguna_has_Postingan_Postingan1_idx` (`Postingan_postingan_id` ASC) ,
  INDEX `fk_Pengguna_has_Postingan_Pengguna1_idx` (`Pengguna_pengguna_id` ASC) ,
  CONSTRAINT `fk_Pengguna_has_Postingan_Pengguna1`
    FOREIGN KEY (`Pengguna_pengguna_id`)
    REFERENCES `dbuts__c`.`pengguna` (`pengguna_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Pengguna_has_Postingan_Postingan1`
    FOREIGN KEY (`Postingan_postingan_id`)
    REFERENCES `dbuts__c`.`postingan` (`postingan_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`rencana_menu`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`rencana_menu` (
  `rencana_menu_id` INT(11) NOT NULL AUTO_INCREMENT,
  `nama_rencana` VARCHAR(100) NOT NULL,
  `deskripsi` TEXT NULL DEFAULT NULL,
  `tanggal_mulai` DATE NOT NULL,
  `tanggal_selesai` DATE NOT NULL,
  `publik` TINYINT(1) NULL DEFAULT 0,
  `dibuat_pada` DATETIME NULL DEFAULT CURRENT_TIMESTAMP(),
  `Pengguna_pengguna_id` INT(11) NOT NULL,
  PRIMARY KEY (`rencana_menu_id`),
  INDEX `fk_Rencana_Menu_Pengguna1_idx` (`Pengguna_pengguna_id` ASC) ,
  CONSTRAINT `fk_Rencana_Menu_Pengguna1`
    FOREIGN KEY (`Pengguna_pengguna_id`)
    REFERENCES `dbuts__c`.`pengguna` (`pengguna_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`detail_rencana_menu`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`detail_rencana_menu` (
  `detail_id` INT(11) NOT NULL AUTO_INCREMENT,
  `tanggal` DATE NOT NULL,
  `jenis_makanan` ENUM('sarapan', 'makan_siang', 'makan_malam', 'camilan') NOT NULL,
  `catatan` TEXT NULL DEFAULT NULL,
  `Rencana_Menu_rencana_menu_id` INT(11) NOT NULL,
  `Resep_resep_id` INT(11) NOT NULL,
  PRIMARY KEY (`detail_id`),
  INDEX `fk_Detail_Rencana_Menu_Rencana_Menu1_idx` (`Rencana_Menu_rencana_menu_id` ASC) ,
  INDEX `fk_Detail_Rencana_Menu_Resep1_idx` (`Resep_resep_id` ASC) ,
  CONSTRAINT `fk_Detail_Rencana_Menu_Rencana_Menu1`
    FOREIGN KEY (`Rencana_Menu_rencana_menu_id`)
    REFERENCES `dbuts__c`.`rencana_menu` (`rencana_menu_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Detail_Rencana_Menu_Resep1`
    FOREIGN KEY (`Resep_resep_id`)
    REFERENCES `dbuts__c`.`resep` (`resep_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`gambar`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`gambar` (
  `gambar_id` INT(11) NOT NULL AUTO_INCREMENT,
  `url_gambar` VARCHAR(255) NULL DEFAULT NULL,
  `urutan` INT(11) NULL DEFAULT NULL,
  `Postingan_postingan_id` INT(11) NOT NULL,
  PRIMARY KEY (`gambar_id`),
  INDEX `fk_Gambar_Postingan1_idx` (`Postingan_postingan_id` ASC) ,
  CONSTRAINT `fk_Gambar_Postingan1`
    FOREIGN KEY (`Postingan_postingan_id`)
    REFERENCES `dbuts__c`.`postingan` (`postingan_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`interaksi`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`interaksi` (
  `interaksi_id` INT(11) NOT NULL AUTO_INCREMENT,
  `tipe` ENUM('suka', 'simpan', 'bagikan', 'komentar') NULL DEFAULT NULL,
  `tanggal_interaksi` DATETIME NULL DEFAULT NULL,
  `teks_komentar` TEXT NULL DEFAULT NULL,
  `Postingan_postingan_id` INT(11) NOT NULL,
  `Pengguna_pengguna_id` INT(11) NOT NULL,
  PRIMARY KEY (`interaksi_id`, `Postingan_postingan_id`, `Pengguna_pengguna_id`),
  INDEX `fk_Interaksi_Postingan1_idx` (`Postingan_postingan_id` ASC) ,
  INDEX `fk_Interaksi_Pengguna1_idx` (`Pengguna_pengguna_id` ASC) ,
  CONSTRAINT `fk_Interaksi_Pengguna1`
    FOREIGN KEY (`Pengguna_pengguna_id`)
    REFERENCES `dbuts__c`.`pengguna` (`pengguna_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Interaksi_Postingan1`
    FOREIGN KEY (`Postingan_postingan_id`)
    REFERENCES `dbuts__c`.`postingan` (`postingan_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`kategori`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`kategori` (
  `kategori_id` INT(11) NOT NULL AUTO_INCREMENT,
  `nama_kategori` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`kategori_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`kolaborasi_resep`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`kolaborasi_resep` (
  `peran` ENUM('pembuat', 'kontributor') NULL DEFAULT NULL,
  `Resep_resep_id` INT(11) NOT NULL,
  `Pengguna_pengguna_id` INT(11) NOT NULL,
  PRIMARY KEY (`Resep_resep_id`, `Pengguna_pengguna_id`),
  INDEX `fk_Kolaborasi_Resep_Resep1_idx` (`Resep_resep_id` ASC) ,
  INDEX `fk_Kolaborasi_Resep_Pengguna1_idx` (`Pengguna_pengguna_id` ASC) ,
  CONSTRAINT `fk_Kolaborasi_Resep_Pengguna1`
    FOREIGN KEY (`Pengguna_pengguna_id`)
    REFERENCES `dbuts__c`.`pengguna` (`pengguna_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Kolaborasi_Resep_Resep1`
    FOREIGN KEY (`Resep_resep_id`)
    REFERENCES `dbuts__c`.`resep` (`resep_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`mengikuti`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`mengikuti` (
  `pengikut_id` INT(11) NOT NULL,
  `diikuti_id` INT(11) NOT NULL,
  PRIMARY KEY (`pengikut_id`, `diikuti_id`),
  INDEX `fk_Mengikuti_Pengguna1_idx` (`pengikut_id` ASC) ,
  INDEX `fk_Mengikuti_Pengguna2_idx` (`diikuti_id` ASC) ,
  CONSTRAINT `fk_Mengikuti_Pengguna1`
    FOREIGN KEY (`pengikut_id`)
    REFERENCES `dbuts__c`.`pengguna` (`pengguna_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Mengikuti_Pengguna2`
    FOREIGN KEY (`diikuti_id`)
    REFERENCES `dbuts__c`.`pengguna` (`pengguna_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`papan_peringkat`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`papan_peringkat` (
  `peringkat_id` INT(11) NOT NULL AUTO_INCREMENT,
  `periode` DATE NULL DEFAULT NULL,
  `skor_pengaruh` INT(11) NULL DEFAULT NULL,
  `kategori` ENUM('paling disukai', 'paling berpengaruh', 'paling banyak direcook') NULL DEFAULT NULL,
  `Pengguna_pengguna_id` INT(11) NOT NULL,
  `Interaksi_interaksi_id` INT(11) NOT NULL,
  `Interaksi_Postingan_postingan_id` INT(11) NOT NULL,
  `Interaksi_Pengguna_pengguna_id` INT(11) NOT NULL,
  PRIMARY KEY (`peringkat_id`),
  INDEX `fk_Papan_Peringkat_Pengguna1_idx` (`Pengguna_pengguna_id` ASC) ,
  INDEX `fk_Papan_Peringkat_Interaksi1_idx` (`Interaksi_interaksi_id` ASC, `Interaksi_Postingan_postingan_id` ASC, `Interaksi_Pengguna_pengguna_id` ASC) ,
  CONSTRAINT `fk_Papan_Peringkat_Interaksi1`
    FOREIGN KEY (`Interaksi_interaksi_id` , `Interaksi_Postingan_postingan_id` , `Interaksi_Pengguna_pengguna_id`)
    REFERENCES `dbuts__c`.`interaksi` (`interaksi_id` , `Postingan_postingan_id` , `Pengguna_pengguna_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Papan_Peringkat_Pengguna1`
    FOREIGN KEY (`Pengguna_pengguna_id`)
    REFERENCES `dbuts__c`.`pengguna` (`pengguna_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`pencarian`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`pencarian` (
  `pencarian_id` INT(11) NOT NULL AUTO_INCREMENT,
  `kata_kunci` VARCHAR(45) NULL DEFAULT NULL,
  `tanggal_pencarian` DATETIME NULL DEFAULT NULL,
  `Pengguna_pengguna_id` INT(11) NOT NULL,
  PRIMARY KEY (`pencarian_id`),
  INDEX `fk_Riwayat_Pencarian_Pengguna1_idx` (`Pengguna_pengguna_id` ASC) ,
  CONSTRAINT `fk_Riwayat_Pencarian_Pengguna1`
    FOREIGN KEY (`Pengguna_pengguna_id`)
    REFERENCES `dbuts__c`.`pengguna` (`pengguna_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`tantangan_memasak`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`tantangan_memasak` (
  `tantangan_id` INT(11) NOT NULL AUTO_INCREMENT,
  `nama_tantangan` VARCHAR(45) NULL DEFAULT NULL,
  `deskripsi` TEXT NULL DEFAULT NULL,
  `tanggal_mulai` DATE NULL DEFAULT NULL,
  `tanggal_selesai` DATE NULL DEFAULT NULL,
  `hadiah` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`tantangan_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`peserta_tantangan`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`peserta_tantangan` (
  `Tantangan_Memasak_tantangan_id` INT(11) NOT NULL,
  `tanggal_ikut` DATETIME NULL DEFAULT NULL,
  `Pengguna_pengguna_id` INT(11) NOT NULL,
  `Postingan_postingan_id` INT(11) NOT NULL,
  PRIMARY KEY (`Tantangan_Memasak_tantangan_id`, `Pengguna_pengguna_id`),
  INDEX `fk_Peserta_Tantangan_Tantangan_Memasak1_idx` (`Tantangan_Memasak_tantangan_id` ASC) ,
  INDEX `fk_Peserta_Tantangan_Pengguna1_idx` (`Pengguna_pengguna_id` ASC) ,
  INDEX `fk_Peserta_Tantangan_Postingan1_idx` (`Postingan_postingan_id` ASC) ,
  CONSTRAINT `fk_Peserta_Tantangan_Pengguna1`
    FOREIGN KEY (`Pengguna_pengguna_id`)
    REFERENCES `dbuts__c`.`pengguna` (`pengguna_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Peserta_Tantangan_Postingan1`
    FOREIGN KEY (`Postingan_postingan_id`)
    REFERENCES `dbuts__c`.`postingan` (`postingan_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Peserta_Tantangan_Tantangan_Memasak1`
    FOREIGN KEY (`Tantangan_Memasak_tantangan_id`)
    REFERENCES `dbuts__c`.`tantangan_memasak` (`tantangan_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`rating`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`rating` (
  `rating_id` INT(11) NOT NULL AUTO_INCREMENT,
  `skor_rating` TINYINT(4) NULL DEFAULT NULL,
  `Pengguna_pengguna_id` INT(11) NOT NULL,
  `Resep_resep_id` INT(11) NOT NULL,
  PRIMARY KEY (`rating_id`),
  INDEX `fk_Rating_Pengguna1_idx` (`Pengguna_pengguna_id` ASC) ,
  INDEX `fk_Rating_Resep1_idx` (`Resep_resep_id` ASC) ,
  CONSTRAINT `fk_Rating_Pengguna1`
    FOREIGN KEY (`Pengguna_pengguna_id`)
    REFERENCES `dbuts__c`.`pengguna` (`pengguna_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Rating_Resep1`
    FOREIGN KEY (`Resep_resep_id`)
    REFERENCES `dbuts__c`.`resep` (`resep_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`recook`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`recook` (
  `recook_id` INT(11) NOT NULL AUTO_INCREMENT,
  `tanggal_percobaan` DATE NULL DEFAULT NULL,
  `hasil` ENUM('berhasil', 'gagal') NULL DEFAULT NULL,
  `Pengguna_pengguna_id` INT(11) NOT NULL,
  `status_baca` ENUM('sudah dibaca', 'belum') NULL DEFAULT NULL,
  `Resep_resep_id` INT(11) NOT NULL,
  PRIMARY KEY (`recook_id`),
  INDEX `fk_Recook_Pengguna1_idx` (`Pengguna_pengguna_id` ASC) ,
  INDEX `fk_Recook_Resep1_idx` (`Resep_resep_id` ASC) ,
  CONSTRAINT `fk_Recook_Pengguna1`
    FOREIGN KEY (`Pengguna_pengguna_id`)
    REFERENCES `dbuts__c`.`pengguna` (`pengguna_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Recook_Resep1`
    FOREIGN KEY (`Resep_resep_id`)
    REFERENCES `dbuts__c`.`resep` (`resep_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`rencana_menu_dibagikan`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`rencana_menu_dibagikan` (
  `Rencana_Menu_rencana_menu_id` INT(11) NOT NULL,
  `Pengguna_pengguna_id` INT(11) NOT NULL,
  `tanggal_dibagikan` DATETIME NULL DEFAULT CURRENT_TIMESTAMP(),
  `status` ENUM('menunggu', 'diterima', 'ditolak') NULL DEFAULT 'menunggu',
  PRIMARY KEY (`Rencana_Menu_rencana_menu_id`, `Pengguna_pengguna_id`),
  INDEX `fk_Rencana_Menu_Dibagikan_Rencana_Menu1_idx` (`Rencana_Menu_rencana_menu_id` ASC) ,
  INDEX `fk_Rencana_Menu_Dibagikan_Pengguna1_idx` (`Pengguna_pengguna_id` ASC) ,
  CONSTRAINT `fk_Rencana_Menu_Dibagikan_Pengguna1`
    FOREIGN KEY (`Pengguna_pengguna_id`)
    REFERENCES `dbuts__c`.`pengguna` (`pengguna_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Rencana_Menu_Dibagikan_Rencana_Menu1`
    FOREIGN KEY (`Rencana_Menu_rencana_menu_id`)
    REFERENCES `dbuts__c`.`rencana_menu` (`rencana_menu_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`resep_bahan`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`resep_bahan` (
  `Bahan_bahan_id` INT(11) NOT NULL,
  `Resep_resep_id` INT(11) NOT NULL,
  `jumlah` DECIMAL(10,2) NULL DEFAULT NULL,
  PRIMARY KEY (`Bahan_bahan_id`, `Resep_resep_id`),
  INDEX `fk_Bahan_has_Resep_Resep1_idx` (`Resep_resep_id` ASC) ,
  INDEX `fk_Bahan_has_Resep_Bahan1_idx` (`Bahan_bahan_id` ASC) ,
  CONSTRAINT `fk_Bahan_has_Resep_Bahan1`
    FOREIGN KEY (`Bahan_bahan_id`)
    REFERENCES `dbuts__c`.`bahan` (`bahan_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Bahan_has_Resep_Resep1`
    FOREIGN KEY (`Resep_resep_id`)
    REFERENCES `dbuts__c`.`resep` (`resep_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`resep_kategori`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`resep_kategori` (
  `Resep_resep_id` INT(11) NOT NULL,
  `Kategori_kategori_id` INT(11) NOT NULL,
  PRIMARY KEY (`Resep_resep_id`, `Kategori_kategori_id`),
  INDEX `fk_Resep_has_Kategori_Kategori1_idx` (`Kategori_kategori_id` ASC) ,
  INDEX `fk_Resep_has_Kategori_Resep1_idx` (`Resep_resep_id` ASC) ,
  CONSTRAINT `fk_Resep_has_Kategori_Kategori1`
    FOREIGN KEY (`Kategori_kategori_id`)
    REFERENCES `dbuts__c`.`kategori` (`kategori_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Resep_has_Kategori_Resep1`
    FOREIGN KEY (`Resep_resep_id`)
    REFERENCES `dbuts__c`.`resep` (`resep_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbuts__c`.`ulasan`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbuts__c`.`ulasan` (
  `ulasan_id` INT(11) NOT NULL AUTO_INCREMENT,
  `isi_ulasan` TEXT NULL DEFAULT NULL,
  `tanggal_ulasan` DATETIME NULL DEFAULT NULL,
  `Resep_resep_id` INT(11) NOT NULL,
  `Pengguna_pengguna_id` INT(11) NOT NULL,
  PRIMARY KEY (`ulasan_id`),
  INDEX `fk_Ulasan_Resep1_idx` (`Resep_resep_id` ASC) ,
  INDEX `fk_Ulasan_Pengguna1_idx` (`Pengguna_pengguna_id` ASC) ,
  CONSTRAINT `fk_Ulasan_Pengguna1`
    FOREIGN KEY (`Pengguna_pengguna_id`)
    REFERENCES `dbuts__c`.`pengguna` (`pengguna_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Ulasan_Resep1`
    FOREIGN KEY (`Resep_resep_id`)
    REFERENCES `dbuts__c`.`resep` (`resep_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
