--create table Vaga(
--IdVaga int identity(1,1),
--Nvaga int unique,
--Situacao char(1) default 'V' -- V de vazio, O de ocupado e R de reserva
--constraint pk_IdVaga primary key (IdVaga)
--)

--create procedure pi_Vaga @Nvaga int as
--insert into Vaga (Nvaga)
--values(@Nvaga)

--create procedure pu_Vaga @Nvaga int, @Situacao char(1) as
--update Vaga set Situacao = @Situacao where Nvaga = @Nvaga

--create procedure ps_vaga @Situacao char(1) as
--select * from Vaga where Situacao = @Situacao

