INSERT INTO Patient (Name, Age)
VALUES ('Sasha', 10), ('Kolya', 15), ('Test', 7), ('Alex', 23)

INSERT Patient
VALUES ('Daniel', 18)

INSERT INTO [Specialization]
VALUES ('Surgeon'), ('Pediatrician'), ('Dentist')

INSERT INTO Doctor (Name, Age, [SpecializationID])
VALUES ('Ivan', 32, 1), ('Vlad', NULL, 2), ('Dima', 26, 3), ('Jack', 24, NULL)

INSERT [dbo].[PatientDoctor]
VALUES (1, 1), (2, 2), (3, 4), (4, 3), (1, 3), (4, 4)

SELECT * FROM Patient
SELECT * FROM [Specialization]
SELECT * FROM [PatientDoctor]
SELECT * FROM Doctor

--1)
SELECT * FROM Patient
WHERE Name LIKE 'Sa%'

--2)
SELECT * FROM Patient
WHERE Name IN ('Sasha', 'Kolya', 'Test')

--3)
SELECT p.Name, p.Age, pd.[PatientId] FROM Patient p
LEFT JOIN [PatientDoctor] pd ON p.ID = pd.[PatientId]
WHERE pd.[PatientId] IS NULL

--4)
SELECT p.Name, COUNT(pd.[DoctorId]) 'Amount of doctors assigned' FROM Patient p
JOIN [PatientDoctor] pd ON p.ID = pd.[PatientId]
GROUP BY p.Name
HAVING COUNT(pd.[DoctorId]) = 1

--5) Patients which have max amount of doctors assigned
SELECT MAX([Amount of doctors].Amount) 'Amount of doctors assigned'
FROM (SELECT COUNT(pd.[DoctorId]) Amount FROM Patient p
	  JOIN [PatientDoctor] pd ON p.ID = pd.[PatientId]
	  GROUP BY p.Name) AS [Amount of doctors]

SELECT p.Name 'Patient name', COUNT(pd.[DoctorId]) 'Amount of doctors assigned' FROM Patient p
JOIN [PatientDoctor] pd ON p.ID = pd.[PatientId]
GROUP BY p.Name
HAVING COUNT(pd.[DoctorId]) = (SELECT MAX([Amount of doctors].Amount)
							   FROM (SELECT COUNT(pd.[DoctorId]) Amount FROM Patient p
									 JOIN [PatientDoctor] pd ON p.ID = pd.[PatientId]
									 GROUP BY p.Name) AS [Amount of doctors])

