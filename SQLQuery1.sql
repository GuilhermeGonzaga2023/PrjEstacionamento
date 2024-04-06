Create table Usuario
(
idUsuario int identity primary key,
nomeUsu varchar(30) not null,
senhaUsu varchar(100) not null,
)

exec pi_Usuario '123','123'

Select *from Usuario

GO
create procedure pi_Usuario
/*parametros*/
@nomeUsu varchar(30),
@senhaUsu varchar(100)
as
/*corpo*/
insert into Usuario
(nomeUsu, senhaUsu)
values (@nomeUsu,@senhaUsu)

drop procedure pi_Cliente
GO

create procedure ps_validaLoginUsu
@nomeUsu varchar(30),
@senhaUsu varchar(100)
as
select * from Usuario
where nomeUsu=@nomeUsu and senhaUsu=@senhaUsu

drop procedure ps_validaLoginUsu

GO
