create database db_academia;
use db_academia;

create table if not exists membros (
	id_membro smallint primary key auto_increment,
    nome varchar(50)not null,
    CPF varchar(11) not null,
    telefone varchar(11) not null,
    data_cadastro date not null
    );
    
    create table if not exists treinos (
    id_treino smallint primary key auto_increment,
    tipo varchar(50) not null,
    descricao varchar(200) not null,
    data_inicio date not null,
    fk_id_membro smallint,
    fk_id_funcionario smallint,
    foreign key (fk_id_membro) references membros(id_membro),
    foreign key (fk_id_funcionario) references funcionarios(id_funcionario)
    );

    create table if not exists pagamentos (
    id_pagamento smallint primary key auto_increment,
    valor decimal not null,
    data_pagamento date not null,
    status_pagamento varchar(20) not null,
    fk_id_membro smallint,
    foreign key (fk_id_membro) references membros(id_membro)
    );

    create table if not exists historico (
    id_historico smallint primary key auto_increment,
    atividade varchar(30) not null,
    data_atividade date not null,
    tempo_execucao int not null,
    fk_id_membro smallint,
    foreign key (fk_id_membro) references membros(id_membro)
    );

    create table if not exists funcionarios (
    id_funcionario smallint primary key auto_increment,
    nome varchar(50) not null,
    cargo varchar(50) not null,
    login varchar(50) not null,
    senha varchar(50) not null
    );
    