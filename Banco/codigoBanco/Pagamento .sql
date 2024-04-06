--create table Pagamento(
--IdPagamento int identity(1,1),
--TipodePag char(1),
--Valor decimal(6,2),
--Bandeira char(2)
--constraint PK_IdPagamento primary key (IdPagamento)
--)

--create procedure pi_Pagamento @TipodePag char(1), @Valor decimal(6,2), @Bandeira char(2) as
--insert into Pagamento (TipodePag, Valor, Bandeira)
--Values(@TipodePag, @Valor, @Bandeira)

--create procedure ps_Pagamento as
--select * from Pagamento order by idPagamento desc
