<script setup>
import { ref, onBeforeMount } from 'vue';
import { useRouter } from 'vue-router'; 
import Api from '../router/Api';

const contatos = ref([]);
const router = useRouter();

onBeforeMount(async () => {
  // não consegui fazer utilizando algo como windiw.addEventListener('load')...
  const token = localStorage.getItem('token');
  console.log(token)
  if(token == null) {
    alert("usuário não autenticado")
    router.push('/');
  } else {
    try {
      const response = await Api.get('/api/v1/contato');
      contatos.value = response.data;
      console.table(response.data)
    } catch (error) {
      console.error('Erro ao obter a lista de contatos:', error);
    }
  }
});
</script>

<template>
  <div class="container">
    <div v-if="contatos.length === 0">
      Nenhum contato encontrado.
    </div>
    <div v-else>
      <div class="p-datatable">
        <div class="p-datatable-wrapper">
          <table>
            <thead>
              <tr>
                <th>Nome</th>
                <th>Email</th>
                <th>Número</th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="(contato, index) in contatos" :key="index">
                <td>{{ contato.nome }}</td>
                <td>{{ contato.email }}</td>
                <td>{{ contato.numero }}</td>
              </tr>
            </tbody>
          </table>
        </div>
      </div>
    </div>
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
