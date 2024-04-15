<script setup>
import { useRouter } from 'vue-router'; 
import Button from 'primevue/button';
import InputText from 'primevue/inputtext';
import axios from 'axios';
import Api from '../router/Api';
import { onBeforeMount } from 'vue';


onBeforeMount(() => {
  const token = localStorage.getItem('token');
  console.log(token)
  if(token == null) {
    alert("usuário não autenticado")
    router.push('/');
  } else {
    const listaContatos = Api.get('/api/v/contato')
    console.table(listaContatos)
  }
});

const router = useRouter();

async function entrar(e) {
  e.preventDefault();

  
}
</script>

<template>
  <div class="container">
    IMPLEMENTE A LISTA AQUI s
  </div>
</template>

<style>
@media (min-width: 1024px) {
  .about {
    min-height: 100vh;
    display: flex;
    align-items: center;
  }
}
</style>
