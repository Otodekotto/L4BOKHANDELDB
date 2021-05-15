
-- SKAPA DATABAS --
Create database Bokhandel
Go

------ SKAPA TABELLER ------
Create table F�rfattare(
ID int identity primary key not null,
F�rnamn nvarchar(60) not null,
Efternamn nvarchar(60) not null,
F�delsedatum nvarchar(60) not null
)
Go

Create table B�cker(
ISBN13 nvarchar(60) primary key not null,
Titel nvarchar(60) not null,
Spr�k nvarchar(60) not null,
Pris int not null,
Utgivningsdatum date not null,
F�rfattareID int References F�rfattare(ID),
)
Go

Create table Butiker(
ID int identity primary key not null,
ButiksNamn nvarchar(60) not null,
Adress nvarchar(60) not null,
Stad nvarchar(60) not null
)
Go

Create table LagerSaldo(
ISBN13ID nvarchar(60) not null References B�cker (ISBN13),
ButiksID int not null References Butiker(ID),
Antal int not null
Primary Key(ISBN13ID,ButiksID)
)
Go



Create table Kunder(
ID int identity Primary key not null,
F�rnamn nvarchar(60) not null,
Efternamn nvarchar(60) not null,
Personnr nvarchar(12) UNIQUE not null
)
Go

Create table [Order](
ID int identity primary key not null,
KundID int references Kunder(ID),
ButikID int references Butiker(ID)
)
Go

----- SKAPA DATA F�R TABELLERNA -----

--F�RFATTARE--
insert into F�rfattare (F�rnamn, Efternamn, F�delsedatum)
values('Joshua', 'Bloch', '19700101');
insert into F�rfattare (F�rnamn, Efternamn, F�delsedatum)
values('Harrison ', 'Ferrone', '19621115');
insert into F�rfattare (F�rnamn, Efternamn, F�delsedatum)
values('Robert ', 'Martin', '19821023');
insert into F�rfattare (F�rnamn, Efternamn, F�delsedatum)
values('Chinmoy ', 'Mirray', '19920103');
Go

--B�CKER--
insert into B�cker (ISBN13, Titel, Spr�k, Pris, Utgivningsdatum, F�rfattareID)
values(9780321356680, 'Slow Java', 'Engelska ', 93 , '2017-12-27',1)
insert into B�cker (ISBN13, Titel, Spr�k, Pris, Utgivningsdatum, F�rfattareID)
values(9781129707755, 'Effective Java', 'Engelska ', 418 , '2013-10-26', 1)
insert into B�cker (ISBN13, Titel, Spr�k, Pris, Utgivningsdatum, F�rfattareID)
values(9782129701388, 'Java or nothing', 'Engelska ', 416 , '2011-11-21', 1)

insert into B�cker (ISBN13, Titel, Spr�k, Pris, Utgivningsdatum, F�rfattareID)
values(9785321356680 , 'Learning C#', 'Svenska ',143 , '2013-06-27', 2)
insert into B�cker (ISBN13, Titel, Spr�k, Pris, Utgivningsdatum, F�rfattareID)
values(9786129707755, 'Games with Unity 2019', 'Engelska ', 756 , '2019-03-30', 2)
insert into B�cker (ISBN13, Titel, Spr�k, Pris, Utgivningsdatum, F�rfattareID)
values(9787129701318, 'C# by Developing', 'Engelska ', 316 , '2007-11-21', 2)

insert into B�cker (ISBN13, Titel, Spr�k, Pris, Utgivningsdatum, F�rfattareID)
values(9788129707725, 'Clean Code', 'Engelska ', 556 , '2019-01-20',3)
insert into B�cker (ISBN13, Titel, Spr�k, Pris, Utgivningsdatum, F�rfattareID)
values(9789119701328, 'Agile Software Craftsmanship', 'Engelska ', 536 , '2017-11-12', 4)

insert into B�cker (ISBN13, Titel, Spr�k, Pris, Utgivningsdatum, F�rfattareID)
values(9789129707745, 'Cracking the Coding Interview', 'Engelska ', 123 , '2012-05-20', 2)
insert into B�cker (ISBN13, Titel, Spr�k, Pris, Utgivningsdatum, F�rfattareID)
values(9789129701368, 'Programming Questions and Solutions', 'Engelska ', 1435 , '2011-11-19',4)
Go


--KUNDER--
insert into Kunder(F�rnamn, Efternamn, Personnr)
values('Rickard', 'Wolf', '900101-1001')
insert into Kunder(F�rnamn, Efternamn, Personnr)
values('Steve', 'Kendrick', '900101-1002')
insert into Kunder(F�rnamn, Efternamn, Personnr)
values('Lemo', 'Stork', '900101-1003')
insert into Kunder(F�rnamn, Efternamn, Personnr)
values('Derrick', 'Brunson', '900101-1004')
insert into Kunder(F�rnamn, Efternamn, Personnr)
values('Mino', 'tao', '900101-1005')

--BUTIK--
insert into Butiker (butiksNamn, Adress, stad)
values('Akademibokhandeln', 'Kungsgatan 61', 'G�teborg')
insert into Butiker (butiksNamn, Adress, stad)
values('Bokhandelsgruppen', 'Sandg�rdsgatan 15', 'V�xj�')
insert into Butiker (butiksNamn, Adress, stad)
values('Bor�s Studentbokhandel', 'All�gatan 6', 'Bor�s')

-- FYLL LAGER I OLIKA BUTIKER -- 

-- BUTIK 1 --
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9780321356680, 1, 20)
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9781129707755, 1, 60)
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9782129701388, 1, 230)

insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9785321356680, 1, 70)
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9786129707755, 1, 10)
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9787129701318, 1, 265)

insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9788129707725, 1, 314)
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9789119701328, 1, 25)

insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9789129707745, 1, 21)
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9789129701368, 1, 22)

-- BUTIK 2 --
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9780321356680, 2, 5)
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9781129707755, 2, 6)
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9782129701388, 2, 23)

insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9785321356680, 2, 7)
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9786129707755, 2, 1)
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9787129701318, 2, 65)

insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9788129707725, 2, 34)
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9789119701328, 2, 5)

insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9789129707745, 2, 1)
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9789129701368, 2, 2)

-- BUTIK 3--
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9780321356680, 3, 76)
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9781129707755, 3, 7)
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9782129701388, 3, 20)

insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9785321356680, 3, 320)
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9786129707755, 3, 14)
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9787129701318, 3, 45)

insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9788129707725, 3, 31)
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9789119701328, 3, 27)

insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9789129707745, 3, 27)
insert into Lagersaldo(ISBN13ID, ButiksID, Antal)
values(9789129701368, 3, 132)
Go

-- Constraint --

ALTER TABLE B�cker
ADD CONSTRAINT ISBN13
Check (Len(ISBN13)=13)
Go

ALTER TABLE B�cker
ADD CONSTRAINT Pris
Check (Pris>0)
Go


-- DEMO --
create view TitlarPerF�rfattare 
as
select 
	Concat(F.F�rnamn, ' ', F.Efternamn) as [Name],
	DATEDIFF(year, F.F�delsedatum, getdate()) as �lder,
	count(distinct B.ISBN13) as Titel,
	sum(B.Pris * LS.Antal) as Lagerv�rde
From F�rfattare as F
join B�cker as B on B.F�rfattareID = F.ID
join LagerSaldo as LS on B.ISBN13 = LS.ISBN13ID
join Butiker as BU on BU.ID = LS.ButiksID
Group by 
	F.ID, F.f�rnamn, F.Efternamn, F.F�delsedatum
Go

select * from F�rfattare
select * from B�cker
select * from Butiker
select * from LagerSaldo
select * from Kunder
Go

Select * from TitlarPerF�rfattare
Go

Select Top 1 * from TitlarPerF�rfattare
Go