--create  table Funcionario(
--IdFunc int identity(1,1),
--Apelido varchar(30),
--Senha varchar(20),
--Nome varchar(200),
--Telefone varchar(12),
--Condicao varchar(8) default 'func'
--constraint pk_IdFunc primary key (idFunc)
--)

--create procedure pi_Funcionario @Apelido varchar(30), @Senha varchar(20),
--@Nome varchar(200), @Telefone varchar(12) as
--insert into Funcionario(Apelido, Senha, Nome, Telefone )
--values(@Apelido, @Senha, @Nome, @Telefone)

--create procedure ps_Funcionario @Nome varchar(200), @Telefone varchar(12), @Condicao varchar(8) as
--select * from Funcionario where Nome like '@Nome %' or Telefone = @Telefone and Condicao = @Condicao

--create procedure login_Funcionario @Apelido varchar(50), @Senha varchar(20) as
--select * from Funcionario where Apelido = @Apelido and Senha = @Senha

--create procedure pu_Funcionario @IdFunc int, @Senha varchar(16), @Nome varchar(150), @Condicao varchar(8), @Telefone varchar(12) as
--update Funcionario set Senha = @Senha, Nome = @Nome, Telefone = @Telefone, Condicao = @Condicao where IdFunc = @IdFunc

