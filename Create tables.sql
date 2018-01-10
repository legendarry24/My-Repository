USE Hospital
GO

CREATE TABLE Patient(
	ID INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL,
	Age INT
)

CREATE TABLE Specialization(
	ID INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL 
)

CREATE TABLE Doctor(
	ID INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL,
	Age INT NULL,
	SpecializationID INT FOREIGN KEY REFERENCES Specialization(ID)
)

CREATE TABLE PatientDoctor(
	PatientId INT,
	DoctorId INT,
	PRIMARY KEY (PatientId, DoctorId),
	FOREIGN KEY (PatientId) REFERENCES Patient(ID),
	FOREIGN KEY (DoctorId) REFERENCES Doctor(ID)
)