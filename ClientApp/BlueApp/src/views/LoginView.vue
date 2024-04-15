<script setup>
import { useRouter } from 'vue-router'; 
import Button from 'primevue/button';
import InputText from 'primevue/inputtext';
import axios from 'axios';
import Api from '../router/Api';

const router = useRouter();

async function entrar(e) {
  e.preventDefault();

  const data = {
    userName: 'felipe',
    password: '123',
    role: 'BlueEmployee'
  };

  try {
    const response = await Api.post('/api/auth/login', data);

    if(response.data.token != null) {
      localStorage.setItem('userName', data.userName)
      localStorage.setItem('password', data.password)
      localStorage.setItem('token', response.data.token)

      router.push('/contact');
    } else {
      alert("não consegui te logar")
    }

  } catch (error) {
    console.log(error)
    alert('Algo deu errado.')
  }
}
</script>

<template>
  <main>
    <div class="container">
      <span class="p-float-label">
        <InputText id="txtUsuario" type="text" v-model="usuario" />
        <label for="txtUsuario">Usuário</label>
      </span>
      <span class="p-float-label">
        <InputText id="txtSenha" type="password" v-model="senha" />
        <label for="txtSenha">Senha</label>
        <Button label="Entrar" @click="entrar" icon="pi pi-user" raised></Button>
      </span>
    </div>
    <p>Já passei o usuário e senha corretos dentro do clique. Para acessá-lo no swagger:</p>
    <p>userName: felipe, password: 123</p>
  </main>
</template>

<style scoped>
.container {
  display: flex;
  align-items: center;
  justify-content: center;
}
p {
  display: flex;
  align-items: center;
  justify-content: center;
}
</style>
