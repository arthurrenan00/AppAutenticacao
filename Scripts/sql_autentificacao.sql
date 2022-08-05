create database dbAutorizacao;

use dbautorizacao;

create table tbUsuario(
UsuarioID int primary key auto_increment,
UsuNome varchar(100) not null unique,
Login varchar(50) not null unique,
Senha varchar(50) not null
);