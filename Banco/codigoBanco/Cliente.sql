--create table Cliente(
--IdCliente int identity(1,1),
--Apelido varchar(50) unique,
--Senha varchar(100),
--Nome varchar(150),
--Placa varchar(8),
--Status char(1) default 'A' -- A para ativo e I para inativo
--constraint pk_idCliente primary key (IdCliente)
--)

--create procedure pi_Cliente @Apelido varchar(50), @Senha varchar(100),
--@Nome varchar(150), @Placa varchar(8) as
--insert into Cliente(Apelido, Senha, Nome, Placa )
--values(@Apelido, @Senha, @Nome, @Placa)

--create procedure ps_Cliente @Nome varchar(150), @Status varchar(8) as
--select * from Cliente where Nome like '@Nome %' and Status = @Status

--create procedure login_Cliente @Apelido varchar(50), @Senha varchar(100) as
--select * from Cliente where Apelido = @Apelido and Senha = @Senha

--create procedure pu_Cliente @IdCliente int, @Nome varchar(150), @Placa varchar(8), @Status varchar(8) as
--update Cliente set Nome = @Nome, Placa = @Placa, Status = @Status where IdCliente = @IdCliente

--create procedure pu_SenhaCliente @Apelido varchar(50), @Senha varchar(100) as 
--update Cliente set Senha = @Senha where Apelido = @Apelido

select * from Cliente

exec login_Cliente 'paulo', '202CB962AC59075B964B07152D234B70'