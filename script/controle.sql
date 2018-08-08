--CREATE DATABASE Controle
drop database Controle
----------------------------------
--drop table Funcionario
select * from Funcionario
CREATE TABLE Funcionario (
    Id int NOT NULL Identity,
    Nome varchar(255) NOT NULL,
    Cpf varchar(255),
    PRIMARY KEY (Id)
);

------------------insert funcionario--------------------------
--insert into Funcionario(Nome, Cpf) values('Leonardo', '140.525.887.03')
--insert into Funcionario(Nome, Cpf) values('Fabricio', '222.333.444.01')
select * from Funcionario
-------------------------table funcionario----------------------

--drop table Requisicao
CREATE TABLE Requisicao (
    Id int NOT NULL Identity,
    Dt_retirada datetime NOT NULL,
    Funcionario varchar(256) Not Null,
    PRIMARY KEY (Id)
);
select * from Requisicao
---------------------insert requisicoes--------------
set dateformat dmy;
--insert into Requisicao(Dt_retirada, Id_func)values('01/08/2018',1);
--insert into Requisicao(Dt_retirada, Id_func)values('01/08/2018',2);
--select * from Requisicao

-----------------------Produtos-----------
--drop table Produtos
--delete Produtos


CREATE TABLE Produtos (
    Id int NOT NULL Identity,
    Nome varchar(300) NOT NULL,
    Preco_custo money NOT NULL,
    Tipo_prod smallint NOT NULL,
    Preco_venda money NOT NULL,
    PRIMARY KEY (Id),
);


--insert into Produtos(Nome, Preco_custo,Preco_venda)values('Refrigerante Lata 350 ML', 0.85,1.20);
--insert into Produtos(Nome, Preco_custo,Preco_venda)values('Café torrão e moído pacote 500 GR', 3.0, 4.50);
--insert into Produtos(Nome, Preco_custo,Preco_venda)values('Arroz branco tipo I pacote 5 KG', 3.90,5.0);
--insert into Produtos(Nome, Preco_custo,Preco_venda)values('Feijão preto tipo I pacote 1 Kg', 1.80,2.90);
--insert into Produtos(Nome, Preco_custo,Preco_venda)values('Cesta Basica', 25.0,30.0);
--insert into Produtos(Nome, Preco_custo,Preco_venda)values('Refrigerante Lata 350 ML fardo com 12 UN', 10.0,15.0);
select * from Produtos
-------------------items requisicao------------------
--drop table ItemsRequisicao
CREATE TABLE ItemsRequisicao (
    Id int NOT NULL Identity,
    Id_req int NOT NULL,
    Id_prod int NOT NULL,
    Qnt_prod int NOT NULL,
    Preco money NOT NULL,
    PRIMARY KEY (Id),
    FOREIGN KEY (Id_req) REFERENCES Requisicao(Id),
    FOREIGN KEY (Id_prod) REFERENCES Produtos(Id)
);

------------------inser itens requisicoes------------
--insert into ItemsRequisicao(Id_req, Id_prod,Qnt_prod,Preco)values(1,1,50,50.0);
--insert into ItemsRequisicao(Id_req, Id_prod,Qnt_prod,Preco)values(1,2,10,100.0);

--insert into ItemsRequisicao(Id_req, Id_prod,Qnt_prod,Preco)values(2,2,50,50.0);
--insert into ItemsRequisicao(Id_req, Id_prod,Qnt_prod,Preco)values(2,1,10,100.0);

select * from ItemsRequisicao

---------------------------produtos comp----------------------
select * from ProdComp
select * from Produtos
--drop table ProdComp;

CREATE TABLE ProdComp (
    Id_comp INT NOT NULL,
    Id_prod INT NOT NULL,
    Qnt_comp int not null,
    PRIMARY KEY (Id_comp,Id_prod),
    FOREIGN KEY (Id_prod) REFERENCES Produtos(Id),
    FOREIGN KEY (Id_comp) REFERENCES Produtos(Id),
);

--insert ProdComp(Id_comp,Id_prod,Qnt_comp)values(4,2,12)
--insert ProdComp(Id_comp,Id_prod,Qnt_comp)values(3,1,1)
--insert ProdComp(Id_comp,Id_prod,Qnt_comp)values(3,5,2)
--insert ProdComp(Id_comp,Id_prod,Qnt_comp)values(3,6,2)

select (select Nome from Produtos where Id = pc.Id_comp) NomeComp,ps.Nome, 
ps.Preco_custo, ps.Preco_venda from 
ProdComp pc
inner join Produtos ps on pc.Id_prod = ps.Id

