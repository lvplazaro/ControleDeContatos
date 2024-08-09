<h1>Agenda Eletrônica para Controle de Contatos</h1>

<p>Este projeto é uma agenda eletrônica desenvolvida como estudo, utilizando tecnologias modernas de desenvolvimento web, como ASP.NET e SQL Server. 
  Criado com o objetivo de gerenciar contatos de forma eficiente, o projeto segue as orientações de uma videoaula do canal Programador Tech no YouTube.</p>

<div align="center">
<img src="https://github.com/user-attachments/assets/9c2c7ff9-912a-4aa6-9296-f4d5c4e889ea" width="700px" />
</div>

<h2>Funcionalidades</h2>
<ul>
  <li>Cadastro de novos contatos</li>
  <li>Edição de contatos existentes</li>
  <li>Exclusão de contatos</li>
  <li>Busca por contatos</li>
  <li>Armazenamento seguro utilizando SQL Server</li>
</ul>

<div align="center">
<img src="https://github.com/user-attachments/assets/d8da74f4-68fe-4e46-a892-bbe69c27f681" width="700px" />
</div>

<div align="center">
<img src="https://github.com/user-attachments/assets/74c29a94-22b1-4db0-b1ab-64d006eb5029" width="700px" />
</div>


<h2>Tecnologias Utilizadas</h2>
<ul>
  <li><strong>ASP.NET Core 5.0:</strong> Framework para desenvolvimento de aplicações web</li>
  <li><strong>SQL Server:</strong> Banco de dados utilizado para armazenamento das informações</li>
  <li><strong>HTML/CSS/JavaScript:</strong> Tecnologias front-end para construção da interface</li>
</ul>

<h2>Como Executar o Projeto</h2>
<ol>
  <li>Clone o repositório:
  </li>

  <li><strong>Configure o banco de dados no `appsettings.json`:</strong>
    <ul>
      <li>Abra o arquivo <code>appsettings.json</code> e altere a string de conexão para apontar para o endereço do SQL Server instalado em seu PC.</li>
    </ul>
  </li>

  <li>Execute as migrações do banco de dados no NuGet Package Manager:
    <pre><code>Update-Database -Context BancoContext</code></pre>
  </li>

  <li><strong>Inserir o primeiro usuário no banco de dados:</strong>
    <ul>
      <li>Execute o comando SQL abaixo para inserir um usuário administrador:
        <pre><code>Insert Into Usuarios (Nome, Login, Email, Perfil, Senha, DataCadastro, DataAtualizacao)
Values ('SeuNome' ,	'Login' ,	'SeuEmail@gmail.com' ,	1 ,	'7110eda4d09e062aa5e4a390b0a572ac0d2c0220' , '2023-11-24 15:52:13.6118069' ,	'2023-11-25 10:36:05.1436876');</code></pre>
      </li>
    </ul>
  </li>

  <li>Execute a aplicação: Entre no sistema utilizando Login e a senha 1234.
    
  </li>

  

</ol>

<h2>Créditos</h2>
<p>Este projeto foi criado seguindo a videoaula do canal <a href="https://www.youtube.com/canalprogramadortech">Programador Tech</a> no YouTube.</p>
