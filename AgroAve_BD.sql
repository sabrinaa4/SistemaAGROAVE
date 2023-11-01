create database sistema_agroave_bd;
use sistema_agroave_bd;

create table Cliente(
id_cli int primary key auto_increment,
nome_cli varchar(100),
email_cli varchar(100),
cpf_cli varchar(14),
telefone_cli varchar(50),
numero_casa_cli int,
rua_cli varchar(100),
bairro_cli varchar(100),
municipio_cli varchar(100),
estado_cli varchar(100)
);

Select * From Cliente;

insert into Cliente values (null, 'Erasmus Kidd', 'erasmuskidd4401@hotmail.com', '111.222.333-44', '(67) 931267-5282', 3709, 'Rua Paracatu', 'Parque Imperial', 'Anápolis', 'Maranhão');
insert into Cliente values (null, 'João Silva', 'joao.silva@email.com', '886.983.010-10', '(11) 91234-5678', 1232, 'Rua das Flores', 'Centro', 'São Paulo', 'São Paulo');
insert into Cliente values (null, 'Maria Santos', 'maria.santos@email.com', '896.059.500-49', '(21) 99876-5432', 5908, 'Avenida Atlântica', 'Copacabana', 'Rio de Janeiro', 'Rio de Janeiro');
insert into Cliente values (null, 'Carlos Souza', 'carlos.souza@email.com', '279.215.320-20',  '(11) 95555-5555', 2504, 'Alameda Santos', 'Jardins', 'São Paulo', 'São Paulo');
insert into Cliente values (null, 'Ana Ferreira', 'ana.ferreira@email.com', '049.420.270-04',  '(31) 92222-2222', 303, 'Rua dos Pinheiros', 'Boa Vista', 'Belo Horizonte', 'Minas Gerais');

create table Cliente_Juridico(
id_clij int primary key auto_increment,
nome_fantasia_clij varchar(100),
email_clij varchar(100),
cnpj_clij varchar(100),
telefone_clij varchar(50),
numero_casa_clij int,
rua_clij varchar(100),
bairro_clij varchar(100),
municipio_clij varchar(100),
estado_clij varchar(100)
);

Select * from Cliente_Juridico;

insert into Cliente_Juridico values (null, 'Varejo Baesso', 'varejo.baesso@gmail.com', '33.235.217/0001-3', '(77) 99336-8343', 123, 'Lauro de Freitas', 'Buraquinho', 'Lauro de Freitas', 'Bahia');
insert into Cliente_Juridico values (null, 'Propaganda Miranda', 'propaganda.miranda@gmail.com', '15.283.118/0001-4', '(88) 2401-4424', 2356, 'Rua Valdetário Mota', 'Vicente Pinzon', 'Fortaleza', 'Ceará');
insert into Cliente_Juridico values (null, 'Brechó Matta', 'brecho.matta@gmail.com', '00.761.255/0001-7', '(49) 2561-3865', 2504, 'Rua João Faustino dos Santos', 'São Pedro', 'Lages', 'Santa Catarina');

create table Perfil_Funcionario(
id_perf int primary key auto_increment,
nome_perf varchar(100),
cpf_perf varchar(50),
telefone_perf varchar(50),
rg_perf varchar(50),
email_perf varchar(100),
funcao_perf varchar(100),
setor_perf varchar(100)
);

#Select * From Perfil_Funcionario;

insert into Perfil_Funcionario values (null, 'João da Silva', '123.456.789-00', '(11) 91111-1111', '12.345.678-9', 'joao@email.com', 'Vendedor', 'Vendas');
insert into Perfil_Funcionario values (null, 'Pedro Alves', '321.654.987-00', '(55) 95555-5555', '32.165.498-7', 'pedro@email.com', 'Caixista', 'Caixa');
insert into Perfil_Funcionario values (null, 'Ana Souza', '654.321.987-00', '(44) 94444-4444', '54.321.987-6', 'ana@email.com', 'Entregador', 'Entregas');

create table Despesa(
id_des int primary key auto_increment,
valor_des double,
data_emissao_des date,
data_vencimento_des date,
parcela_des varchar(50),
descricao_des varchar(100),
status_des varchar(50),
nome_des varchar(100),
forma_pag_des varchar(50)
);

#Select * From Despesa;

insert into Despesa values (null, 150.00, '2023-01-05', '2023-01-10', 1, 'Aluguel das salas.', 'Pendente', 'Aluguel', 'Boleto');
insert into Despesa values (null, 100.00, '2023-06-19', '2023-07-01', 1, 'Aluguel da máquina de pipoca.', 'Pago', 'Máquina', 'Cartão de crédito');
insert into Despesa values (null, 200.00, '2023-06-30', '2023-06-19', 1, 'Internet para os clientes.', 'Pago', 'Internet', 'Boleto bancário');

create table Aves(
id_ave int primary key auto_increment,
observacoes_ave varchar(100),
cor_identificacao_ave varchar(50),
quant_obito_ave int,
raca_ave varchar(50),
data_entrada_ave varchar(100),
lote_ave varchar(100),
numero_galpao_ave int
);

#Select * From Aves;

insert into Aves values (null, 'Ave possui uma plumagem exuberante e colorida.', 'Vermelho', 0, 'Galinha caipira', '2023-06-19', 'Lote 254', 1);
insert into Aves values (null, 'Ave está comendo menos do que o normal.', 'Amarelo', 1, 'Canela preta', '2023-06-18', 'Lote 13', 2);
insert into Aves values (null, 'Ave está se recuperando de uma infecção respiratória.', 'Verde', 5, 'Caneluda do Catolé', '2023-06-17', 'Lote 789', 3);

create table Produto (
id_prod int primary key auto_increment,
nome_prod  varchar(100),
descricao_prod varchar(400),
data_fabricacao_prod varchar(50),
data_vencimento_prod varchar(50),
codigo_barras_prod varchar(45),
origem_prod varchar(100),
valor_prod double
);

Select * From Produto;

insert into Produto values (null, 'Cartela de ovos', 'Cartela com 12 unidades', '2023-06-19', '2023-06-26', '123456789', 'Granja Primavera', 14.99);
insert into Produto values (null, 'Ovo Branco', 'jhdsh', '2023-06-19', '2023-07-19', '1234567890123', 'Granja Primavera', 1.25);
insert into Produto values (null, 'Ovo Vermelho', 'sdwsd', '2023-06-19', '2023-06-25', '5678901234567','Granja Primavera', 2.00);

create table Fornecedor(
id_for int primary key auto_increment,
nome_fantasia_for varchar(150),
razao_social_for varchar(100),
cnpj_for varchar(100),
telefone_for varchar(45),
email_for varchar(100),
numero_for int,
rua_for varchar(100),
bairro_for varchar(100),
municipio_for varchar(40),
estado_for varchar(30)
);

#Select * From Fornecedor;

insert into Fornecedor values (null, 'Rações CIA', '5555', '73.680.269/0001-30',  '(83) 2592-5389', 'racoes@gmail.com', 987, 'José Pereira da Cunha', 'Platô do Piquiá', 'Boca do Acre', 'Amazonas');
insert into Fornecedor values (null, 'Sarah & Alessandra', 'Sarah e Alessandra Alimentos Ltda',  '539.787.725-67', '(16) 3775-5740', 'sarahealessandra@gmail.com', 21, 'Avenida Vinte', 'Portal Terra da Saudade', 'Matão', 'São Paulo');
insert into Fornecedor values (null, 'CB Gráfica', 'Carlos e Benício Gráfica ME', '628.821.430-58', '(11) 2503-7154', 'carlosebeniciograficamegmail.com', 2425, 'Guarda Municipal Paulo Benedito de Camargo', 'Conjunto Habitacional São José', 'Campo Limpo Paulista', 'São Paulo');

create table Estoque(
id_est int primary key auto_increment,
nome_produto_est varchar(100),
codigo_est varchar(100),
descricao_est varchar(150),
quantidade_est int,
data_fabricacao_est date,
data_vencimento_est date,
id_prod_fk int,
foreign key(id_prod_fk) references Produto (id_prod)
);

#Select * From Estoque;

insert into Estoque values (null, 'Quirela', 'Quirela pros galos.', '2022-01-01', '2023-12-31', '12345', 100, 3);
insert into Estoque values (null, 'Rémdeio', 'Remédio pros pintinhos', '2022-03-15', '2024-06-30', '67890', 50, 2);
insert into Estoque values (null, 'Fitinha', 'Ftinhas para diferenciar os lotes', '2022-06-20', '2023-09-30', '23456', 200, 1);

create table Compra (
id_com int primary key auto_increment,
valor_com double,
tipo_pagamento_com varchar(100),
descricao_com varchar(100),
unidade_com int,
data_com date,
hora_com time,
id_for_fk int,
foreign key(id_for_fk) references Fornecedor (id_for),
id_des_fk int,
foreign key(id_des_fk) references Despesa (id_des)
);

#Select * From Compra;

insert into Compra values (null, 100.00, 'Cartão de crédito', 'Compra de material', 2, '2023-04-19', '10:40:00', 3, 1);
insert into Compra values (null, 246.23, 'Dinheiro', 'Compra de remédio', 3, '2023-07-23', '15:34:00', 1, 2);
insert into Compra values (null, 500.00, 'Boleto', 'Compra de remédio', 7, '2023-10-22', '11:11:45', 2, 3);

create table Producao (
id_pro int primary key auto_increment,
nome_pro varchar(100),
quantidade_pro int,
data_pro date,
descricao_pro varchar(400),
producao_diaria_pro varchar(50),
producao_semanal_pro varchar(50),
producao_mensal_pro varchar(50),
producao_esperada_pro varchar(50),
producao_real_pro varchar(50)
);

#Select * From Producao;

insert into Producao values (null, 'Ovo branco', 1000, '2023-05-21', 'Produção de ovos brancos', 1000, 7000, 30000, 38000, 30000);
insert into Producao values (null, 'Ovo vermelho', 500, '2023-04-21', 'Produção diária de frangos inteiros', 500, 3500, 15000, 24000, 15000);
insert into Producao values (null, 'Ovo Vermelho', 800, '2023-06-21', 'Produção de ovos vermelhos', 800, 5600, 24000, 36000, 24000);

create table Funcionario(
id_fun int primary key auto_increment,
nome_fun varchar(100),
rg_fun varchar(50),
cpf_fun varchar(50),
telefone_fun varchar(50),
carteira_trabalho_fun varchar(50),
funcao_fun varchar(50),
setor_fun varchar(50),
numero_fun varchar(50),
rua_fun varchar(50),
bairro_fun varchar(50),
municipio_fun varchar(50),
estado_fun varchar(50),
salario_fun double,
id_perf_fk int,
foreign key(id_perf_fk) references Perfil_Usuario (id_perf)
);

Select * From Funcionario;

insert into Funcionario values (null, 'João Silva', '12.345.678-9','12.345.678-9', '(98) 97654-8321', 'CT123456', 'Vendedor','Vendas',' 1435', 'Lindicelma Alves de Jesus', 'Bosque dos Ipês', 'Ji-Paraná', 'Rondônia',1235, 1);
insert into Funcionario values (null, 'Pedro Alvez', '32.165.498-7','12.345.678-9', '(54) 93210-2987', 'CT567890', 'Caixista', 'Caixa','1890',  'Chico Mendes', 'Parque São Pedro', 'Ji-Paraná', 'Rondônia',1235, 1);
insert into Funcionario values (null, 'Ana Souza', '54.321.987-6','12.345.678-9', '(98) 97654-9321', 'CT987654', 'Entregador', 'Entregas', '205', 'Angelim', 'Nova Brasília', 'Ji-Paraná', 'Rondônia', 1235,1);

create table Entrega(
id_ent int primary key auto_increment,
nome_ent varchar(100),
status_ent varchar(200),
endereco_ent varchar(100),
taxa_ent double,
valor_troco_ent double,
hora_ent time,
id_fun_fk int,
foreign key(id_fun_fk) references Funcionario (id_fun)
);

#Select * From Funcionario;

insert into Entrega values (null, 'Cartelas de ovos brancos', 'Pendente', 'Rua Júlio Guerra, Bairro São Bernardo', 5.00, 0.00, '10:25:00', 3);
insert into Entrega values (null, 'Cartelas de ovos vermelhos', 'Em andamento', 'Rua Rita Martins Leite, Bairro Jardim São Cristóvão', 8.00, 50.00, '14:30:00', 3);
insert into Entrega values (null, 'Ovos', 'Concluída', 'Rua Ipê, Bairro Nova brasília', 10.00, 1.00, '16:45:00', 3);

create table Venda(
id_ven int primary key auto_increment,
cnpj_ven varchar(30),
cpf_ven varchar(14),
data_ven date,
hora_ven time,
valor_ven double,
tipo_pagamento_ven varchar(30),
descricao_ven varchar(250),
unidades_ven int,
parcela_ven int,
id_ent_fk int,
foreign key(id_ent_fk) references Entrega (id_ent),
id_cli_fk int,
foreign key(id_cli_fk) references Cliente (id_cli),
id_clij_fk int,
foreign key(id_clij_fk) references Cliente_Juridico (id_clij),
id_fun_fk int,
foreign key(id_fun_fk) references Funcionario (id_fun)
);

#Select * From Venda;

insert into Venda values (null, '66.259.745/0001-88', '719.172.960-02', '2023-06-19', '10:00:00', 500.00, 'Transferência', 'Venda de 15 cartelas de ovos', 15, 3, 2, 5, 1, 2);
insert into Venda values (null, '09.055.821/0001-08', '985.084.790-50', '2023-06-19', '14:30:00', 1008.00, 'Boleto', 'Venda de 36 cartelas de ovos brancos', 36, 5, 1, 4, 1, 1);
insert into Venda values (null, '79.077.089/0001-44', '878.071.600-80', '2023-06-19', '16:45:00', 728.00, 'Cartão de crédito', 'Venda de 26 cartelas de ovos vermelhos', 26, 4, 3, 2, 1, 3);

create table Caixa(
id_cai int primary key auto_increment,
numero_cai int,
data_cai date,
horario_abertura_cai varchar(8),
horario_fechamento_cai varchar(8),
valor_inicial_cai double,
valor_final_cai double,
id_fun_fk int,
foreign key(id_fun_fk) references Funcionario (id_fun)
);

#Select * From Caixa;

insert into Caixa values (null, 1, '2023-05-14', '07:34:00', '18:02:28', 2500.00, 10789.77, 2);
insert into Caixa values (null, 2, '2023-05-15', '07:31:50', '18:00:59', 2500.00, 23456.98, 2);
insert into Caixa values (null, 4, '2023-05-16', '07:30:00', '18:10:38', 2500.00, 8680.90, 2);

create table Recebimento(
int_rec int primary key auto_increment,
nome_rec varchar(100),
valor_rec double,
parcela_rec varchar(50),
status_rec varchar(100),
hora_rec time,
data_rec date,
forma_recebimento_rec varchar(50),
vencimento_parcela_rec date,
id_cai_fk int,
foreign key(id_cai_fk) references Caixa (id_cai),
id_ven_fk int,
foreign key(id_ven_fk) references Venda (id_ven)
);

#Select * From Recebimento;

insert into Recebimento values (null, 'Ovos', 500.00, 1, 'Pago', '09:30:00', '2023-06-19', 'Transferência', '2023-07-01', 1, 1);
insert into Recebimento values (null, 'Ovos', 1006.00, 2, 'Pendente', '12:05:59', '2023-06-19', 'Boleto', '2023-07-10', 2, 2);
insert into Recebimento values (null, 'Ovos', 728.00, 3, 'Atrasado', '15:47:09', '2023-06-19', 'Cartão de crédito', '2023-06-30', 3, 3);

create table Pagamento (
id_pag int primary key auto_increment,
mome_pag varchar(100),
status_pag varchar(50),
data_emissao_pag date,
data_vencimento_pag date,
descricao_pag varchar(200),
forma_pagamento_pag varchar(50),
valor_pag double,
hora_pag time,
id_cai_fk int,
foreign key(id_cai_fk) references Caixa (id_cai),
id_des_fk int,
foreign key(id_des_fk) references Despesa (id_des)
);

#Select * From Pagamento;

insert into Pagamento values (null, 'Máquina', 'Pago', '2023-06-19', '2023-07-19', 'Pagamento aluguel', 'Cartão de crédito', 100.00, '10:00:06', 3, 2);
insert into Pagamento values (null, 'Aluguel', 'Atrasado', '2023-06-19', '2023-06-30', 'Pagamento aluguel', 'Boleto', 150.00, '14:30:00', 1, 1);
insert into Pagamento values (null, 'Internt', 'Pago', '2023-06-19', '2023-06-25', 'Pagamento fornecedor', 'Boleto bancário', 200.00, '16:45:00', 2, 3);

create table Produto_Compra (
id_prod_com int primary key auto_increment,
id_prod_fk int,
foreign key(id_prod_fk) references Produto (id_prod),
id_com_fk int,
foreign key(id_com_fk) references Compra (id_com)
);

create table Produto_Venda (
id_prod_ven int primary key auto_increment,
id_prod_fk int,
foreign key(id_prod_fk) references Produto (id_prod),
id_ven_fk int,
foreign key(id_ven_fk) references Venda (id_ven)
);

#Select * From Produto_Venda;

insert into Produto_Venda values (null, 2, 3);
insert into Produto_Venda values (null, 1, 1);
insert into Produto_Venda values (null, 3, 3);

create table Producao_Produto (
id_pro_prod int primary key auto_increment,
quantidade_pro_prod int,
id_pro_fk int,
foreign key(id_pro_fk) references Producao (id_pro),
id_prod_fk int,
foreign key(id_prod_fk) references Produto (id_prod)
);

#Select * From Producao_Produto;

insert into Producao_Produto values (null, 11, 1, 3);
insert into Producao_Produto values (null, 9, 3, 2);
insert into Producao_Produto values (null, 3, 2, 1);

create table Funcionario_Producao (
if_fun_pro int primary key auto_increment,
int_fun_fk int,
foreign key(int_fun_fk) references Funcionario (id_fun),
id_pro_fk int,
foreign key(id_pro_fk) references Producao (id_pro)
);

#Select * From Funcionario_Producao;

insert into Funcionario_Producao values (null, 3, 3);
insert into Funcionario_Producao values (null, 1, 2);
insert into Funcionario_Producao values (null, 2, 1);

create table Producao_Aves ( 
id_pro_ave int primary key auto_increment,
quantidade_pro_ave int,
id_pro_fk int,
foreign key(id_pro_fk) references Producao (id_pro),
id_ave_fk int,
foreign key(id_ave_fk) references Aves (id_ave)
);

#Select * From Producao_Aves;

insert into Producao_Aves values (null, 20, 2, 3);
insert into Producao_Aves values (null, 13, 1, 2);
insert into Producao_Aves values (null, 5, 3, 1);




############ REGRA DE NEGÓCIO ############

# TABELA CLIENTE
Delimiter $$
create procedure salvarCliente (nome varchar(100), email varchar(100), cpf varchar(14), telefone varchar(50), numero_casa int, rua varchar(100), 
bairro varchar(100), municipio varchar(100), estado_cli varchar(100))
begin
declare ob_telefone varchar (100);

set ob_telefone = (select telefone_cli from Cliente where (telefone_cli = telefone));

if (ob_telefone = '') or (ob_telefone is null) then 
    insert into Cliente values (null, nome, email, cpf, telefone, numero_casa, rua, bairro, municipio, estado_cli);
   
else 
    select 'O TELEFONE informado já existe na base de dados!' as Alerta;
end if;

end;
$$ Delimiter ;

call salvarCliente ('Natasha Romanoff', 'romanoffnat@gmail.com', '123.456.215-75', '(69) 99635-2478', 1235, 'rua domingues', 'centro', 'Brooklyn', 'Nova Iorque');
call salvarCliente ('Tony Stark', 'stark.tony@gmail.com', '578.659.214-35', '(69) 94851-2315', 654, 'rua cerejeiras', 'leste', 'Brooklyn', 'Nova Iorque');
call salvarCliente ('Peter Parker', 'peterparker@gmail.com', '789.678.124-12', '(69) 96663-2255', 5478, 'rua do amigão', 'sul', 'Nova Iorque', 'Nova Iorque');

select * from Cliente;


# TABELA PERFIL DO USUÁRIO
Delimiter $$
create procedure salvarPerfilUsuario (nome varchar(100), cpf varchar(50), telefone varchar(50), rg varchar(50), email varchar(100), funcao varchar(100), setor varchar(100))
begin
declare ob_telefone varchar (100);

set ob_telefone = (select telefone_perf from Perfil_Usuario where (telefone_perf = telefone));

if (ob_telefone = '') or (ob_telefone is null) then 
    insert into Perfil_Usuario values (null, nome, cpf, telefone, rg, email, funcao, setor);
   
else 
    select 'O TELEFONE informado já existe na base de dados!' as Alerta;
end if;

end;
$$ Delimiter ;

call salvarPerfilUsuario ('Bruce Banner', '321.654.983-89', '(69) 99968-3265', '54.321.888-2', 'banner@gmail.com', 'Vendedor', 'Vendas');
call salvarPerfilUsuario ('Steve Rogers', '123.546.547-21', '(69) 99654-5487', '54.548.987-3', 'rogers@gmail.com', 'Vendedor', 'Vendas');
call salvarPerfilUsuario ('Wanda Maximof', '546.112.996-65', '(69) 99677-2165', '65.326.999-6', 'maximof@gmail.com', 'Caixa', 'Caixas');

select * from Perfil_Usuario;



# TABELA DESPESA
Delimiter $$
create procedure salvarDespesa (valor double, data_emissao date, data_vencimento date, parcela varchar(50), descricao varchar(100), status varchar(50), nome varchar(100), 
forma_pag varchar(50))
begin

if (nome <> '') and (valor <> '') then
    insert into Despesa values (null, valor, data_emissao, data_vencimento, parcela, descricao, status, nome, forma_pag);
   
else 
    select 'Os campos NOME e VALOR são obrigatorios!' as Alerta;
end if;

end;
$$ Delimiter ;

call salvarDespesa (100.00, '2023-09-20', '2023-10-20', 1, 'Aluguel do barracão', 'Pendente', 'Alugel', 'Cartão de Crédito');
call salvarDespesa (75.50, '2023-09-25', '2023-10-25', 1, 'Compras no upermercado', 'Pendente', 'Supermercado', 'Dinheiro');
call salvarDespesa (50.00, '2023-09-15', '2023-10-15', 2, 'Conta de Luz', 'Pago', 'Luz', 'Débito Automático');

select * from Despesa;


# TABELA AVES
Delimiter $$
create procedure salvarAves (observacoes varchar(100), cor_identificacao varchar(50), quant_obito int, raca varchar(50), data_entrada varchar(100), lote varchar(100), 
numero_galpao int)
begin 

if (cor_identificacao <> '') and (raca <> '') then
    insert into Aves values (null, observacoes, cor_identificacao, quant_obito, raca, data_entrada, lote, numero_galpao);
   
else 
    select 'Os campos COR IDENTIFICAÇÃO e RAÇA são obrigatorios!' as Alerta;
end if;

end;
$$ Delimiter ;

call salvarAves ('Ave saudável, sem observações adicionais', 'Branca', 0, 'Carijó', '2023-09-20', 'Lote 123', 1);
call salvarAves ('Ave com penas um pouco desgastadas', 'Preta', 1, 'Brahma', '2023-09-18', 'Lote 456', 2);
call salvarAves ('Ave com plumagem brilhante e saudável', 'Vermelha', 0, 'Brahma', '2023-09-22', 'Lote 789', 3);

select * from Aves;


# TABELA PRODUTO
Delimiter $$
create procedure salvarProduto (nome varchar(100), descricao varchar(400), data_fabricacao varchar(50), data_vencimento varchar(50), codigo_barras varchar(45), origem varchar(100),
valor double)
begin

if (nome <> '') and (valor <> '') then
    insert into Produto values (null, nome, descricao, data_fabricacao, data_vencimento, codigo_barras, origem, valor);
   
else 
    select 'Os campos NOME e VALOR são obrigatorios!' as Alerta;
end if;

end;
$$ Delimiter ;

call salvarProduto ('ovos vermelhos', 'ovos fresquinhos', '2023-09-18', '2024-09-18', '9876543210987', 'Importado', 3.49);
call salvarProduto ('ovos vermelhos', 'ovos fresquinhos', '2023-09-22', '2024-09-22', '5678901234567', 'Nacional', 2.99);
call salvarProduto ('ovos brancos', 'ovos fresquinhos', '2023-09-20', '2024-09-20', '1234567890123', 'Nacional', 5.99);

select * from Produto;


# TABELA FORNECEDOR
Delimiter $$
create procedure salvarFornecedor (nome_fantasia varchar(150), razao_social varchar(100), cnpj varchar(100), telefone varchar(45), email varchar(100), numero int, rua varchar(100),
bairro varchar(100), municipio varchar(40), estado varchar(30))
begin
declare val_cnpj varchar(100);

set val_cnpj = (select cnpj_for from Fornecedor where (cnpj_for = cnpj));

if (val_cnpj = '') or (val_cnpj is null) then
   insert into Fornecedor values (null, nome_fantasia, razao_social, cnpj, telefone, email, numero, rua, bairro, municipio, estado);
   
else
	select 'O CNPJ informado já existe na base de dados!' as Alerta;
end if; 

end;
$$ Delimiter ;
call salvarFornecedor ('Suplementos', 'Sônia e Gustavo Suplementos Ltda.', '80.095.291/0001-88', '(69) 99456-7890', 'buffet.sg@example.com', '1823', '7 de setembro', 'Centro', 'Cacoal', 'Rondônia');
call salvarFornecedor ('Bezerra', 'Bezerra Carvel Ltda.', '50.254.743/0001-66', '(69) 97789-0123', 'bezerra@example.com', '456', 'Avenida amarelo', 'Centro', 'Ariquemes', 'Rondônia');
call salvarFornecedor ('Antunes', 'Antunes Ximenes Ltda.', '44.234.157/0001-57', '(69) 98456-7890', 'ximenesant@example.com', '913', 'Rua da saudade', 'Centro', 'Cacoal', 'Rondônia');

select * from Fornecedor;


# TABELA ESTOQUE
Delimiter $$
create procedure salvarEstoque (nome varchar(100), descricao varchar(150), data_fabricacao date, data_vencimento date, codigo varchar(100), quantidade int, prod_fk int)
begin

if (codigo <> '') and (descricao <> '') then
    insert into Estoque values (null, nome, descricao, data_fabricacao, data_vencimento, codigo, quantidade, prod_fk);
   
else 
    select 'Os campos CÓDIGO e DESCRIÇÃO são obrigatorios!' as Alerta;
end if;

end;
$$ Delimiter ;

call salvarEstoque('Ovos vermelho', 'Ovos vermelhos das galinhas do galpão 1', '2023-09-18', '2024-09-18', '67890', 75, 2);
call salvarEstoque('Ovos brancos', 'Ovos vermelhos das galinhas do galpão 3', '2023-09-22', '2024-09-22', '54321', 50, 1);
call salvarEstoque('Garnisé', 'Galinha da raça Garnisé, branca', '2023-09-20', '2024-09-20', '12345', 100, 3);

select * from Estoque;


# TABELA COMPRA 
Delimiter $$
create procedure salvarCompra (valor double, tipo_pagamento varchar(100), descricao varchar(100), unidade int, data date, hora time, fornedor_fk int, despesa_fk int)
begin

if (valor <> '') and (descricao <> '') then
    insert into Compra values (null, valor, tipo_pagamento, descricao, unidade, data, hora, fornedor_fk, despesa_fk);
   
else 
    select 'Os campos VALOR e DESCRIÇÃO são obrigatorios!' as Alerta;
end if;

end;
$$ Delimiter ;

call salvarCompra (100.00, 'Cartão de Crédito', 'Compra  remedio', 3, '2023-09-20', '14:30:00' , 3, 1);
call salvarCompra (50.00, 'Dinheiro' , 'Compra material', 1, '2023-09-19', '12:45:00', 1, 2);
call salvarCompra (200.00, 'Transferência Bancária', 'Compra material', 2, '2023-09-18', '10:15:00', 2, 3);

select * from Compra;


# TABELA PRODUÇÃO
Delimiter $$
create procedure salvarProducao (nome varchar(100), quantidade int, data date, descricao varchar(150), producao_diaria varchar(50), producao_semanal varchar(50), producao_mensal varchar(50),
producao_esperada varchar(50), producao_real varchar(50))
begin 

if (nome <> '') and (quantidade <> '') then
    insert into Producao values (null, nome, quantidade, data, descricao, producao_diaria, producao_semanal, producao_mensal, producao_esperada, producao_real);
   
else 
    select 'Os campos NOME e QUANTIDADE são obrigatorios!' as Alerta;
end if;

end;
$$ Delimiter ;

call salvarProducao ('Ovo Vermelho' , 1000, '2023-09-20', 'Produção de ovos', 1000, 7000 , 30000, 28000, 2800);
call salvarProducao ('Ovo Branco', 800, '2023-09-20', 'Produção de ovos', 800, 5600, 24000 ,22000, 22000);
call salvarProducao ('Ovo Vermelho',950, '2023-09-19', 'Produção de ovos', 950, 6650, 28500, 28000, 27800);

select * from Producao;


#TABELA FUNCIONÁRIO
Delimiter $$
create procedure salvarFuncionario (nome varchar(100), rg varchar(50), cpf varchar(50), telefone varchar(50), carteira_trabalho varchar(50), funcao varchar(50), setor varchar(50),
numero varchar(50), rua varchar(50), bairro varchar(50), municipio varchar(50), estado varchar(50), salario double, perfil_fk int)
begin
declare ob_telefone varchar (50);

set ob_telefone = (select telefone_fun from Funcionario where (telefone_fun = telefone));

if (ob_telefone = '') or (ob_telefone is null) then 
    insert into Funcionario values (null, nome, rg, cpf, telefone, carteira_trabalho, funcao, setor, numero, rua, bairro, municipio, estado, salario, perfil_fk);
   
else 
    select 'O TELEFONE informado já existe na base de dados!' as Alerta;
end if;

end;
$$ Delimiter ;

call salvarFuncionario ('João da Silva', '1234567', '123.456.789-00', '(11) 1234-5678', 'CT1234567', 'Gerente', 'Administração', 123, 'Rua Principal', 'Centro', 'Porto Velho', 'São Paulo', 5000.00, 1);
call salvarFuncionario ('Maria Oliveira', '9876543', '987.654.321-00', '(22) 9876-5432', 'CT9876543', 'Veterinário', 'Saúde', 45, 'Monte Castelo', 'Urupa', 'Jaru', 'Rio de Janeiro',   4000.00, 2);
call salvarFuncionario ('Pedro Santos', '4567890', '456.789.123-00', '(33) 4567-8901', 'CT4567890', 'Agricultor', 'Produção', 671, 'Goiânia', 'Capelasso', 'Cacoal', 'MG', 3500.00, 3);

select * from Funcionario;

;

# TABELA ENTREGA 
Delimiter $$
create procedure salvarEntrega (nome varchar(100), status varchar(200), endereco varchar(100), taxa double, valor_troco double, hora time, funcionario_fk int)
begin

if (nome <> '') and (endereco <> '') then
    insert into Entrega values (null, nome, status, endereco, taxa, valor_troco, hora, funcionario_fk);
   
else 
    select 'Os campos NOME e ENDEREÇO são obrigatorios!' as Alerta;
end if;

end;
$$ Delimiter ;

call salvarEntrega ('Ovos Vermelhos', 'Entregue', 'Monte Catelo', 5.00, 20.00,'14:30:00', 3);
call salvarEntrega ('Ovos Brancos', 'Pendente', 'São Paulo', 4.50, 0.00,'11:15:00', 3);
call salvarEntrega ('Ovos Vemelhos', 'Entregue', 'Av. JK', 6.00, 10.00, '16:45:00', 3);
                                                                               
select * from Entrega;


# TABELA VENDA 
Delimiter $$
create procedure salvarVenda (cnpj varchar(30), cpf varchar(14), data date, hora time, valor double, tipo_pagamento varchar(30), descricao varchar(250), unidades int, parcela int, 
entregas_fk int, cliente_fk int, clientej_fk int, funcionario_fk int)
begin

if (cpf <> '') and (cnpj <> '') then
    insert into Venda values (null, cnpj, cpf, data, hora, valor, tipo_pagamento, descricao, unidades, parcela, entregas_fk, cliente_fk, clientej_fk, funcionario_fk);
   
else 
    select 'Os campos CPF e CNPJ são obrigatorios!' as Alerta;
end if;

end;
$$ Delimiter ;

call salvarVenda ('12.345.678/0001-01', '456.789.123-00', '2023-09-20', '14:30:00', 2000.00, 'Cartão de Crédito', 'Venda de 50 cartelas de ovos brancos', 50, 1, 2, 5, 1, 2);
call salvarVenda ('23.456.789/0001-03', '123.456.789-00', '2023-09-19', '11:15:00', 20.50, 'Dinheiro', 'Venda de 1 cartela de ovos brancos', 1, 1, 1, 4, 1, 3);
call salvarVenda ('98.765.432/0001-02', '456.789.123-11', '2023-09-18', '16:45:00', 120.00, 'Transferência Bancária', 'Venda de 2 cartelas de ovos brancos', 2, 2, 3, 2, 1, 1);



# TABELA CAIXA 
Delimiter $$
create procedure salvarCaixa (numero int, data date, horario_abertura time, horario_fechamento time, valor_inicial double, valor_final double,
funcionario_fk int)
begin 

if (numero <> '') then
    insert into Caixa values (null, numero, data, horario_abertura, horario_fechamento, valor_inicial, valor_final, funcionario_fk);
   
else 
    select 'O campo NÚMERO é obrigatorio!' as Alerta;
end if;

end;
$$ Delimiter ;

call salvarCaixa (10, '2023-09-20', '08:00:00', '16:30:00', 3000.00, 23789.00, 2);
call salvarCaixa (12, '2023-09-19', '07:45:00', '17:15:00', 3000.00, 13987.90, 1);
call salvarCaixa (13, '2023-09-18', '08:30:00', '16:00:00', 3000.00, 15500.98, 3);

select * from Caixa;


# TABELA RECEBIMENTO
Delimiter $$
create procedure salvarRecebimento (nome varchar(100), valor double, parcela varchar(50), status varchar(100), hora time, data date, forma_recebimento varchar(50), 
vencimento_parcela date, caixa_fk int, venda_fk int)
begin

if (nome <> '') and (valor <> '') then
    insert into Recebimento values (null, nome, valor, parcela, status, hora, data, forma_recebimento, vencimento_parcela, caixa_fk, venda_fk);
   
else 
    select 'Os campos NOME e VALOR são obrigatorios!' as Alerta;
end if;

end;
$$ Delimiter ;

call salvarRecebimento ('Roger Santos', 150.00, 1, 'Pago', '14:30:00', '2023-09-20', 'Cartão de Crédito', '2023-10-05', 1, 1);
call salvarRecebimento ('Simone Santana', 100.00, 1, 'Pago', '11:15:00', '2023-09-19', 'Dinheiro', '2023-10-04', 2, 2);
call salvarRecebimento ('Luan Will', 300.00, 2 , 'Pendente', '16:45:00', '2023-09-18', 'Transferência Bancária', '2023-09-30', 3, 3);

select * from Recebimento;


# TABELA PAGAMENTO
Delimiter $$
create procedure salvarPagamento (nome varchar(100), status varchar(50), data_emissao date, data_vencimento date, descricao varchar(200), forma_pagamento varchar(50), valor double,
hora time, caixa_fk int, despesa_fk int)
begin

if (nome <> '') and (valor <> '') then
    insert into Pagamento values (null, nome, status, data_emissao, data_vencimento, descricao, forma_pagamento, valor, hora, caixa_fk, despesa_fk);
   
else 
    select 'Os campos NOME e VALOR são obrigatorios!' as Alerta;
end if;

end;
$$ Delimiter ;

call salvarPagamento ('Ração', 'Pendente', '2023-09-20', '2023-10-05', 'Compra de ração', 'Transferência Bancária', 1500.00, '14:30:00', 3, 2);
call salvarPagamento ('Galinhas', 'Pago', '2023-09-19', '2023-01-05', 'Compra de galinhas', 'Dinheiro', 5000.00, '11:15:00', 1, 1);
call salvarPagamento ('Equecipamentos', 'Pendente', '2023-09-18', '2023-09-30', 'Compra de equipamentos', 'Cheque', 2500.00, '16:45:00', 2, 3);

select * from Pagamento;


# TABELA PRODUTO_VENDA
Delimiter $$
create procedure salvarProdutoVenda (produto_fk int, venda_fk int)
begin 

if (produto_fk <> '') and (venda_fk <> '') then
    insert into Produto_Venda values (null, produto_fk, venda_fk);
   
else 
    select 'Os campos PRODUTO_FK e VENDA_FK são obrigatorios!' as Alerta;
end if;

end;
$$ Delimiter ;

call salvarProdutoVenda (1, 2);
call salvarProdutoVenda (3, 3);
call salvarProdutoVenda (2, 1);

select * from Produto_Venda;


# TABELA PRODUÇÃO_PRODUTO
Delimiter $$
create procedure salvarProducaoProduto (quantidade int, producao_fk int, produto_fk int)
begin

if (quantidade <> '') then
    insert into Producao_Produto values (null, quantidade, producao_fk, produto_fk);
   
else 
    select 'O campo QUANTIDADE é obrigatorio!' as Alerta;
end if;

end;
$$ Delimiter ;

call salvarProducaoProduto (11, 3, 2);
call salvarProducaoProduto (20, 1, 3);
call salvarProducaoProduto (6, 2, 1);

select * from Producao_Produto;


# TABELA FUNCIONÁRIO_PRODUÇÃO
Delimiter $$
create procedure salvarFuncionarioProducao (funcionario_fk int, producao_fk int)
begin

if (funcionario_fk <> '') and (producao_fk <> '') then
    insert into Funcionario_Producao values (null, funcionario_fk, producao_fk);
   
else 
    select 'Os campos FUNCIONARIO_FK e PRODUCAO_FK são obrigatorios!' as Alerta;
end if;

end;
$$ Delimiter ;

call salvarFuncionarioProducao (3, 3);
call salvarFuncionarioProducao (1, 2);
call salvarFuncionarioProducao (2, 1);

select * from Funcionario_Producao;


#TABELA SALVAR_PRODUCAOAVES
Delimiter $$
create procedure salvarProducaoAves (quantidade int, producao_fk int, aves_fk int)
begin

if (quantidade <> '') then
    insert into Producao_Aves values (null, quantidade, producao_fk, aves_fk);
   
else 
    select 'O campo QUANTIDADE é obrigatorio!' as Alerta;
end if;

end;
$$ Delimiter ;

call salvarProducaoAves (6, 1, 2);
call salvarProducaoAves (10, 3, 1);
call salvarProducaoAves (2, 2, 3);

select * from Producao_Aves;
