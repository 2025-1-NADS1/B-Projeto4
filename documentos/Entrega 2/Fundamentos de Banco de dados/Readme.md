Este diretório contém a modelagem física do banco de dados da aplicação de casa inteligente. Abaixo estão descritas duas tabelas principais implementadas.

---

Tabela: Dispositivo

Armazena os dados dos dispositivos instalados nos cômodos da residência.

| Campo         | Tipo         | Descrição                            |
|---------------|--------------|--------------------------------------|
| id_dispositivo| INT (PK)     | Identificador único do dispositivo   |
| nome          | VARCHAR(100) | Nome do dispositivo                  |
| tipo          | VARCHAR(50)  | Tipo (ex: lâmpada, tomada, etc.)     |
| status        | VARCHAR(20)  | Estado atual (ex: ligado, desligado) |
| id_comodo     | INT (FK)     | Relaciona ao cômodo onde está        |

---

Tabela: Comodo

Armazena os cômodos da residência onde os dispositivos estão instalados.

Esquema da Tabela

| Campo       | Tipo         | Descrição                                |
|-------------|--------------|------------------------------------------|
| id_comodo   | INT (PK)     | Identificador único do cômodo            |
| nome        | VARCHAR(100) | Nome do cômodo (ex: Sala de Estar)       |

Exemplo de Dados

```SQL
INSERT INTO Comodo (nome) VALUES 
('Sala de Estar'),
('Cozinha'),
('Quarto Principal');
