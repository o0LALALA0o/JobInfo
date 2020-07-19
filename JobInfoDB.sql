use master
go

if exists(select * from sysdatabases where name = 'JobInfoDB')
drop database JobInfoDB
go

--�������ݿ�
create database JobDB
go

--ʹ��JobInfoDB���ݿ�
use JobDB
go

--����ְλ�б�JobInfo
create table JobInfoDB
(
	JobId int identity(1000,1) primary key,
	JobTitle varchar(50) not null,	--����
	JobContent varchar(1000),	--����
	JobCo varchar(50),	--���ڵ�λ
	JobDate date ,	--����ʱ��
	isDel int,	--�Ƿ�ɾ��
	Visits  int,	--������
	
)

--����ͼƬ��
create table JobImg
(
	ImgId int identity(1,1) primary key,
	JobId int,	--������Id
	ImgName varchar(500) not null,	--ͼƬ����
	ImgOrder int,	--ͼƬ˳��
)

go

insert into JobInfo(JobTitle,JobContent,JobCo,JobDate,isDel,Visits) values('����ͨѶȫ���и�ְ����������������','123','��˾','2020-03-15',0,0)

insert into JobInfo(JobTitle,JobContent,JobCo,JobDate,isDel,Visits) values('����ha��','123','��˾','2020-03-16',0,0)

select * from JobInfo
