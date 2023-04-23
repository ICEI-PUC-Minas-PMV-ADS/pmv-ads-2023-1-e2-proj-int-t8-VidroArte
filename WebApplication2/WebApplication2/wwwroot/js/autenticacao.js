//autenticação usuário
async function verificaUsuario() {
    const res = await fetch('/json/usuarios.json');
    const contato = await res.json();
    usuarioSistema = document.getElementById('usuario');
    senhaSistema = document.getElementById('senha');
    console.log(usuarioSistema);
    console.log(senhaSistema);

    var user = contato.find((item) => { return item.email == usuarioSistema.value })
    if (user) {
        if (user.senha == senhaSistema.value) {
            localStorage.setItem('nomeUsuario', user.nome);
            window.location = "/Home/home";
        }
        else {
            alert("Senha invalida")
        }
    }
    else {
        alert("Usuário não encontrado")
    }
}

//logout usuario, tanto por click quanto por inatividade
startTimer();
document.addEventListener('mousemove', resetTimer);
document.addEventListener('keypress', resetTimer);
function verificasessao() {
    const nomeUsuario = localStorage.getItem('nomeUsuario');
    if (!nomeUsuario) {
        window.location.href = '/home';
    }
    else {
        document.getElementById("bemvindo").innerText = `Bem-vindo, ${nomeUsuario}.`;
    }
}




function startTimer() {
    timeoutId = setTimeout(logout, 300000); // timeout de 5 minuto
}

function resetTimer() {
    clearTimeout(timeoutId);
    startTimer();
}


function logout() {
    localStorage.removeItem("nomeUsuario");
    window.location.href = "/Home"; // redireciona para a página de login
}
function cancelar() {
    window.location.href = "/Home/home"; // redireciona para a página de login
}


