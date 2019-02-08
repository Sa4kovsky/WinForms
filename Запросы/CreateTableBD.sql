USE TaskBD;

-- ���������� ������ � ���� ������
CREATE TABLE Staff (
	[StaffId] [INT] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Surname] [VARCHAR](100),
	[Name] [VARCHAR](100),
	[Patronymic] [VARCHAR](100)
	);

CREATE TABLE Task (
	[TaskId] [INT] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[NameTask] [VARCHAR](100),
	[WorkLoad] [INT],
	[StartDate] [DATE],
	[ExpiryDate] [DATE],
	[Status] [VARCHAR](10),
	[StaffId] [INT]
	);

	-- ���������� �������� ������
	INSERT INTO Staff ([Surname], [Name], [Patronymic]) VALUES ('����������', '�������', '����������');
	INSERT INTO Staff ([Surname], [Name], [Patronymic]) VALUES ('���������', '���������', '����������');
	INSERT INTO Staff ([Surname], [Name], [Patronymic]) VALUES ('������', '�������', '��������');

	INSERT INTO Task ([NameTask], [WorkLoad], [StartDate], [ExpiryDate], [Status], [StaffId]) VALUES ('Task Qulix', '24', '07.02.2019', '08.02.2019', '� ��������', '1');