--create table Fluxo(
--IdFluxo int identity(1,1),
--IdCliente int,
--IdVaga int,
--IdPagamento int,
--Entrada datetime,
--Saida datetime,
--constraint pk_IdFluxo primary key (IdFluxo),
--constraint fk_IdCliente foreign key (IdCliente) references Cliente(IdCliente),
--constraint fk_IdVaga foreign key (IdVaga) references Vaga(IdVaga),
--constraint fk_IdPagamento foreign key (IdPagamento) references Pagamento(IdPagamento)
--)

--create procedure pi_Fluxo @IdCliente int, @IdVaga int, @Entrada datetime as
--Insert Into Fluxo (IdCliente, IdVaga, Entrada)
--Values(@IdCliente, @IdVaga, @Entrada)

--create procedure ps_Fluxo as
--Select F.IdFluxo, C.Nome, C.Placa, V.IdVaga, P.IdPagamento, 
--P.Valor, P.TipodePag, P.Bandeira From Fluxo F inner join 
--Vaga V on F.IdVaga = V.IdVaga inner join
--Cliente C on F.IdCliente = C.IdCliente inner join
--Pagamento P on F.IdPagamento = P.IdPagamento
--where V.Situacao = 'O' 

--create procedure pu_Fluxo @IdFluxo int, @IdPagamento int, @Saida dateTime as 
--update Fluxo set IdPagamento = @IdPagamento, Saida = @Saida where IdFluxo = @IdFluxo