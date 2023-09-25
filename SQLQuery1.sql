CREATE TABLE Customer
(
 [CustomerID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [CustomerName] VARCHAR(50) NOT NULL, 
    [CustomerEmail] VARCHAR(50) NOT NULL, 
    [CustomerPassword] VARCHAR(50) NOT NULL, 
    [CustomerGender] VARCHAR(6) NOT NULL, 
    [CustomerAddress] VARCHAR(100) NOT NULL, 
    [CustomerRole] VARCHAR(5) NOT NULL
)

CREATE TABLE TransactionHeader
(
 [TransactionID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [TransactionDate] DATE NOT NULL, 
    [CustomerID] INT NOT NULL,
 FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)

)

CREATE TABLE Artist
(
 [ArtistID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [ArtistName] VARCHAR(50) NOT NULL, 
    [ArtistImage] VARCHAR(50) NOT NULL
)

CREATE TABLE Album
(
 [AlbumID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [ArtistID] INT NOT NULL, 
    [AlbumName] VARCHAR(50) NOT NULL, 
    [AlbumImage] VARCHAR(50) NOT NULL, 
    [AlbumPrice] INT NOT NULL, 
    [AlbumStock] INT NOT NULL,
 [AlbumDescription] varchar(255) NOT NULL,
 FOREIGN KEY (ArtistID) REFERENCES Artist(ArtistID)
)

CREATE TABLE TransactionDetail
(
 [TransactionID] INT NOT NULL,
 [AlbumID] INT NOT NULL,
 [Qty] INT NOT NULL,
 FOREIGN KEY (TransactionID) REFERENCES Transactionheader(TransactionID),
 FOREIGN KEY (AlbumID) REFERENCES Album(AlbumID),
 PRIMARY KEY (TransactionID, AlbumID)
)

CREATE TABLE Cart
(
 [CustomerID] INT NOT NULL,
 [AlbumID] INT NOT NULL,
 [Qty] INT NOT NULL,
 FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
 FOREIGN KEY (AlbumID) REFERENCES Album(AlbumID),
 PRIMARY KEY (CustomerID, AlbumID)
)