-- Tabel Produk
CREATE TABLE produk (
    id_produk INT PRIMARY KEY,
    nama VARCHAR(50),
    harga DECIMAL(50),
    stok INT,
    tanggal_exp DATE
);
ALTER TABLE produk ADD COLUMN gambar_produk BYTEA;
select * from produk


-- Tabel Admin
CREATE TABLE admin (
    id_admin INT PRIMARY KEY,
    username_admin VARCHAR(50) UNIQUE,
    password_admin VARCHAR(50)
);

INSERT INTO admin VALUES (1, 'admin', 'admin')
SELECT * FROM ADMIN

-- Tabel Pembayaran
CREATE TABLE pembayaran (
    id_pembayaran INT PRIMARY KEY,
    jenis_pembayaran VARCHAR(50)
);

-- Tabel Tunai
CREATE TABLE tunai (
    id_tunai INT PRIMARY KEY,
    id_pembayaran INT,
    total_bayar DECIMAL(50),
    kembalian DECIMAL(50),
    FOREIGN KEY (id_pembayaran) REFERENCES Pembayaran(id_pembayaran)
);

-- Tabel Qris
CREATE TABLE qris (
    id_qris INT PRIMARY KEY,
    id_pembayaran INT,
    nama_merchant VARCHAR(50),
    FOREIGN KEY (id_pembayaran) REFERENCES Pembayaran(id_pembayaran)
);

-- Tabel Transaksi
CREATE TABLE transaksi (
    id_transaksi INT PRIMARY KEY,
    tanggal_transaksi DATE,
    jumlah_produk INT,
    total_pembayaran DECIMAL(50),
    id_produk INT,
    id_admin INT,
    id_pembayaran INT,
    FOREIGN KEY (id_produk) REFERENCES Produk(id_produk),
    FOREIGN KEY (id_admin) REFERENCES Admin(id_admin),
    FOREIGN KEY (id_pembayaran) REFERENCES Pembayaran(id_pembayaran)
);
