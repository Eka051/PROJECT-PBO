CREATE TABLE Produk (
	id_produk INT PRIMARY KEY,
	nama varchar(20) NOT NULL,
	harga int NOT NULL,
	stok int NOT NULL,
	diskon int NOT NULL,
	pajak int NOT NULL,
	tanggal_exp date NOT NULL,
	deskripsi_produk varchar(50) NOT NULL
)

CREATE TABLE Jenis_produk (
	id_jenis_produk int PRIMARY KEY,
	nama_jenis_produk varchar NOT NULL
)

CREATE TABLE Kondisi (
	id_kondisi int PRIMARY KEY,
	nama_kondisi varchar(20) NOT NULL
)

CREATE TABLE Transaksi (
	id_transaksi int PRIMARY KEY,
	tanggal_transaksi date NOT NULL,
	total_pembayaran_transaksi int NOT NULL,
	jumlah_produk int NOT NULL
)

CREATE TABLE Metode_pembayaran (
	id_metode_pembayaran int PRIMARY KEY,
	jenis_metode_pembayaran varchar(20)
)

CREATE TABLE Pelanggan (
	id_pelanggan int PRIMARY KEY,
	nama_pelanggan varchar(20) NOT NULL,
	email_pelanggan varchar(20) NOT NULL
)

CREATE TABLE Admin_ (
	id_admin int PRIMARY KEY,
	username_admin varchar(20) NOT NULL,
	password_admin varchar(20) NOT NULL
)

INSERT INTO admin_ VALUES (1, 'admin', 'admin')

select *
from Produk

select *
from Jenis_produk

select *
from Kondisi

select *
from Transaksi

select *
from Metode_pembayaran

select *
from Pelanggan

select *
from Admin_
