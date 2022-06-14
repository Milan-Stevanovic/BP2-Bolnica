CREATE TABLE Bolnica
(
	idBolnice INT IDENTITY(1,1) PRIMARY KEY ,
	nazivBolnice VARCHAR(255) NOT NULL
);


CREATE TABLE Zaposleni
(
	idZaposlenog INT IDENTITY(1,1) PRIMARY KEY,
	jmbgZ VARCHAR(15) NOT NULL,
	imeZ VARCHAR(255) NOT NULL,
	prezimeZ VARCHAR(255) NOT NULL,
	plataZ INT,
	tipZaposlenog VARCHAR(255) NOT NULL,
	idBolnice INT FOREIGN KEY REFERENCES Bolnica(idBolnice) NOT NULL
);

CREATE TABLE ZdravstveniRadnik
(
	idZaposlenog INT PRIMARY KEY FOREIGN KEY REFERENCES Zaposleni(idZaposlenog),
	brojLicence INT,
	tipZdrRad VARCHAR(255) NOT NULL,
);

CREATE TABLE Obezbedjenje
(
	idZaposlenog INT PRIMARY KEY FOREIGN KEY REFERENCES Zaposleni(idZaposlenog),
	dozvolaZaOruzje BIT
);

CREATE TABLE Odeljenje
(
	idOdeljenja INT IDENTITY(1,1) PRIMARY KEY,
	nazivOdeljenja VARCHAR(255) NOT NULL,
	sprat INT
);

CREATE TABLE Spremacica
(
	idZaposlenog INT PRIMARY KEY FOREIGN KEY REFERENCES Zaposleni(idZaposlenog),
	idOdeljenja INT FOREIGN KEY REFERENCES Odeljenje(idOdeljenja) NOT NULL
);

CREATE TABLE Doktor
(
	idZaposlenog INT PRIMARY KEY FOREIGN KEY REFERENCES ZdravstveniRadnik(idZaposlenog),
	specijalizacija VARCHAR(255)
);

CREATE TABLE MedicinskiTehnicar
(
	idZaposlenog INT PRIMARY KEY FOREIGN KEY REFERENCES ZdravstveniRadnik(idZaposlenog),
);

CREATE TABLE Pacijent
(
	brojZdrKnjiz INT PRIMARY KEY,
	jmbgP VARCHAR(15) NOT NULL,
	imeP VARCHAR(255) NOT NULL,
	prezimeP varchar(255) NOT NULL
);

CREATE TABLE Pregled
(
	idP INT IDENTITY(1,1) PRIMARY KEY,
	datumP DATE NOT NULL,
	vremeP TIME NOT NULL,
	brojZdrKnjiz INT FOREIGN KEY REFERENCES Pacijent(brojZdrKnjiz) NOT NULL,
	idZaposlenog INT FOREIGN KEY REFERENCES MedicinskiTehnicar(idZaposlenog) NOT NULL
);

CREATE TABLE ObavljaPregled
(
	idZaposlenog INT FOREIGN KEY REFERENCES Doktor(idZaposlenog),
	idP INT  FOREIGN KEY REFERENCES Pregled(idP),
	PRIMARY KEY (idZaposlenog, idP)
);

CREATE TABLE OperacionaSala
(
	rbSale INT IDENTITY(1,1),
	nazivSale VARCHAR(255),
	imaXray BIT,
	sprat INT,
	idOdeljenja INT FOREIGN KEY REFERENCES Odeljenje(idOdeljenja) NOT NULL,
	PRIMARY KEY (rbSale, idOdeljenja)
);

CREATE TABLE Intervencija
(
	idI INT IDENTITY(1,1) PRIMARY KEY,
	datumI DATE NOT NULL,
	vremeI TIME NOT NULL,
	trajanjeI INT,
	idZaposlenog INT NOT NULL,
	idP INT NOT NULL,
	rbSale INT NOT NULL,
	idOdeljenja INT NOT NULL,
	FOREIGN KEY (idZaposlenog, idP) REFERENCES ObavljaPregled(idZaposlenog, idP),
	FOREIGN KEY (rbSale, idOdeljenja) REFERENCES OperacionaSala(rbSale, idOdeljenja)
);