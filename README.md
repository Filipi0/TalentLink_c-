# TalentLink 🔗

**Conectando talentos às melhores oportunidades**

dotnet watch

## 📋 Descrição

TalentLink é uma plataforma moderna desenvolvida em Blazor Server (.NET 9) que conecta profissionais talentosos com as melhores oportunidades de trabalho disponíveis no mercado.

## 🚀 Tecnologias Utilizadas

- **Blazor Server** - Framework web da Microsoft
- **.NET 9** - Runtime e SDK
- **C#** - Linguagem de programação
- **Bootstrap 5** - Framework CSS
- **CSS3** - Estilização personalizada
- **HTML5** - Estrutura da aplicação

## 🎨 Características

- ✅ **Design Responsivo** - Funciona em desktop, tablet e mobile
- ✅ **Tema Moderno** - Interface elegante em azul e branco
- ✅ **Tela de Login** - Sistema de autenticação
- ✅ **Validação de Formulários** - Validação client-side e server-side
- ✅ **Layout Limpo** - Interface intuitiva e fácil de usar

## 🏗️ Estrutura do Projeto

```
├── Components/
│   ├── Layout/
│   │   ├── EmptyLayout.razor      # Layout para páginas sem navegação
│   │   ├── MainLayout.razor       # Layout principal com navegação
│   │   └── NavMenu.razor          # Menu de navegação
│   ├── Pages/
│   │   ├── Home.razor             # Página inicial
│   │   ├── Login.razor            # Tela de login
│   │   ├── Counter.razor          # Exemplo de contador
│   │   └── Weather.razor          # Exemplo de clima
│   ├── App.razor                  # Componente raiz da aplicação
│   ├── Routes.razor               # Configuração de rotas
│   └── _Imports.razor             # Importações globais
├── wwwroot/
│   ├── app.css                    # Estilos globais
│   ├── login.css                  # Estilos específicos do login
│   ├── favicon.png                # Ícone da aplicação
│   └── lib/                       # Bibliotecas externas
├── Properties/
│   └── launchSettings.json        # Configurações de execução
├── appsettings.json               # Configurações da aplicação
├── appsettings.Development.json   # Configurações de desenvolvimento
├── Program.cs                     # Ponto de entrada da aplicação
└── talentlink.csproj             # Arquivo de projeto
```

## 🛠️ Como Executar

### Pré-requisitos
- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Editor de código (Visual Studio, VS Code, etc.)

### Passos para execução

1. **Clone o repositório**
   ```bash
   git clone https://github.com/Filipi0/TalentLink_c-.git
   cd TalentLink_c-
   ```

2. **Restaure as dependências**
   ```bash
   dotnet restore
   ```

3. **Execute a aplicação**
   ```bash
   dotnet run
   ```

4. **Acesse no navegador**
   ```
   http://localhost:5180
   ```

## 🔐 Tela de Login

A aplicação possui uma tela de login elegante e moderna com:

- **Design Responsivo** - Adapta-se a qualquer tamanho de tela
- **Validação de Formulários** - Validação em tempo real
- **Credenciais de Teste**:
  - Email: `admin@talentlink.com`
  - Senha: `123456`

### Acesso direto ao login:
```
http://localhost:5180/login
```

## 🎯 Funcionalidades Implementadas

- [x] Tela de login responsiva
- [x] Validação de formulários
- [x] Layout sem navegação para páginas específicas
- [x] Tema personalizado em azul e branco
- [x] Estrutura preparada para integração com API

## 🔮 Próximas Funcionalidades

- [ ] Dashboard de oportunidades
- [ ] Integração com API de vagas
- [ ] Sistema de autenticação JWT
- [ ] Página de cadastro de usuários
- [ ] Perfil do usuário
- [ ] Listagem e filtros de vagas
- [ ] Sistema de candidaturas

## 🎥 Screenshots

### Tela de Login
![Login](docs/login-screenshot.png)

*Tela de login moderna com tema azul e branco*

## 🤝 Contribuição

1. Faça um fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/AmazingFeature`)
3. Commit suas mudanças (`git commit -m 'Add some AmazingFeature'`)
4. Push para a branch (`git push origin feature/AmazingFeature`)
5. Abra um Pull Request

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## 👨‍💻 Autor

**Filipi** - [GitHub](https://github.com/Filipi0)

---

⭐ **Se este projeto te ajudou, deixe uma estrela!** ⭐
