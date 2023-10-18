create database sistema_agroave_bd;
use sistema_agroave_bd;

create table Cliente_Fisico(
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

Select * From Cliente_Fisico;

insert into Cliente_Fisico values (null, 'Erasmus Kidd', 'erasmuskidd4401@hotmail.com', '111.222.333-44', '(67) 931267-5282', 3709, 'Rua Paracatu', 'Parque Imperial', 'Anápolis', 'Maranhão');
insert into Cliente_Fisico values (null, 'João Silva', 'joao.silva@email.com', '886.983.010-10', '(11) 91234-5678', 1232, 'Rua das Flores', 'Centro', 'São Paulo', 'São Paulo');
insert into Cliente_Fisico values (null, 'Maria Santos', 'maria.santos@email.com', '896.059.500-49', '(21) 99876-5432', 5908, 'Avenida Atlântica', 'Copacabana', 'Rio de Janeiro', 'Rio de Janeiro');
insert into Cliente_Fisico values (null, 'Carlos Souza', 'carlos.souza@email.com', '279.215.320-20',  '(11) 95555-5555', 2504, 'Alameda Santos', 'Jardins', 'São Paulo', 'São Paulo');
insert into Cliente_Fisico values (null, 'Ana Ferreira', 'ana.ferreira@email.com', '049.420.270-04',  '(31) 92222-2222', 303, 'Rua dos Pinheiros', 'Boa Vista', 'Belo Horizonte', 'Minas Gerais');

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

create table Perfil_Usuario(
id_perf int primary key auto_increment,
nome_perf varchar(100),
cpf_perf varchar(50),
telefone_perf varchar(50),
rg_perf varchar(50),
email_perf varchar(100),
funcao_perf varchar(100),
setor_perf varchar(100)
);

#Select * From Perfil_Usuario;

insert into Perfil_usuario values (null, 'João da Silva', '123.456.789-00', '(11) 91111-1111', '12.345.678-9', 'joao@email.com', 'Vendedor', 'Vendas');
insert into Perfil_usuario values (null, 'Pedro Alves', '321.654.987-00', '(55) 95555-5555', '32.165.498-7', 'pedro@email.com', 'Caixista', 'Caixa');
insert into Perfil_usuario values (null, 'Ana Souza', '654.321.987-00', '(44) 94444-4444', '54.321.987-6', 'ana@email.com', 'Entregador', 'Entregas');

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

Select * From Fornecedor;

insert into Fornecedor values (null, 'Rações CIA', '5555', '73.680.269/0001-30',  '(83) 2592-5389', 'racoes@gmail.com', 987, 'José Pereira da Cunha', 'Platô do Piquiá', 'Boca do Acre', 'Amazonas');
insert into Fornecedor values (null, 'Sarah & Alessandra', 'Sarah e Alessandra Alimentos Ltda',  '539.787.725-67', '(16) 3775-5740', 'sarahealessandra@gmail.com', 21, 'Avenida Vinte', 'Portal Terra da Saudade', 'Matão', 'São Paulo');
insert into Fornecedor values (null, 'CB Gráfica', 'Carlos e Benício Gráfica ME', '628.821.430-58', '(11) 2503-7154', 'carlosebeniciograficamegmail.com', 2425, 'Guarda Municipal Paulo Benedito de Camargo', 'Conjunto Habitacional São José', 'Campo Limpo Paulista', 'São Paulo');

create table Estoque(
id_est int primary key auto_increment,
nome_est varchar(100),
descricao_est varchar(150),
data_fabricacao_est date,
data_vencimento_est date,
codigo_est varchar(100),
quantidade_est int,
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
foreign key(id_cli_fk) references Cliente_Fisico (id_cli),
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
horario_abertura_cai time,
horario_fechamento_cai time,
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
