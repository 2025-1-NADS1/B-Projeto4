Este diretório contém a modelagem física do banco de dados da aplicação de casa inteligente. Abaixo estão descritas duas tabelas principais implementadas.

---

📄 Tabela: Dispositivo

Armazena os dados dos dispositivos instalados nos cômodos da residência.

| Campo         | Tipo         | Descrição                            |
|---------------|--------------|--------------------------------------|
| id_dispositivo| INT (PK)     | Identificador único do dispositivo   |
| nome          | VARCHAR(100) | Nome do dispositivo                  |
| tipo          | VARCHAR(50)  | Tipo (ex: lâmpada, tomada, etc.)     |
| status        | VARCHAR(20)  | Estado atual (ex: ligado, desligado) |
| id_comodo     | INT (FK)     | Relaciona ao cômodo onde está        |

---

Tabela: Comando

Registra os comandos enviados aos dispositivos pelos usuários.

| Campo         | Tipo          | Descrição                               |
|---------------|---------------|-----------------------------------------|
| id_comando    | INT (PK)      | Identificador único do comando          |
| acao          | VARCHAR(100)  | Ação executada (ex: "ligar luz")        |
| data_hora     | DATETIME      | Data e hora da execução                 |
| id_usuario    | INT (FK)      | Relaciona ao usuário que enviou o comando |
| id_dispositivo| INT (FK)      | Dispositivo afetado pelo comando        |

---
 Arquivos `.sql` com as instruções de criação das tabelas podem ser encontrados nesta pasta.
