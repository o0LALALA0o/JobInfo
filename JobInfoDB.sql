use master
go

if exists(select * from sysdatabases where name = 'JobInfoDB')
drop database JobInfoDB
go

--创建数据库
create database JobDB
go

--使用JobInfoDB数据库
use JobDB
go

--创建职位列表JobInfo
create table JobInfoDB
(
	JobId int identity(1000,1) primary key,
	JobTitle varchar(50) not null,	--标题
	JobContent varchar(1000),	--内容
	JobCo varchar(50),	--所在单位
	JobDate date ,	--发布时间
	isDel int,	--是否删除
	Visits  int,	--访问量
	
)

--创建图片表
create table JobImg
(
	ImgId int identity(1,1) primary key,
	JobId int,	--关联的Id
	ImgName varchar(500) not null,	--图片名称
	ImgOrder int,	--图片顺序
)

go

insert into JobInfo(JobTitle,JobContent,JobCo,JobDate,isDel,Visits) values('中兴通讯全国中高职线上面试启动啦！','123','公司','2020-03-15',0,0)

insert into JobInfo(JobTitle,JobContent,JobCo,JobDate,isDel,Visits) values('哈哈ha！','123','公司','2020-03-16',0,0)

select * from JobInfo
