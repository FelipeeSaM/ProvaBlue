<script setup>
import { ref, onBeforeMount } from 'vue';
import { useRouter } from 'vue-router'; 
import Api from '../router/Api';

const contatos = ref([]);
const router = useRouter();

onBeforeMount(async () => {
  // não consegui fazer utilizando algo como windiw.addEventListener('load', ...)
  const token = localStorage.getItem('token');
  
  if(token == null) {
    alert("usuário não autenticado")
    router.push('/');
  } else {
    try {
      const response = await Api.get('/api/v1/contato');
      contatos.value = response.data;

    } catch (error) {
      console.error('Erro ao obter a lista de contatos:', error);
    }
  }
});

const redirectToEdit = (id) => {
  try {

    router.push(`/edit/${id}`)

  } catch (error) {
    
  }
};

async function DeleteContact(id) {
  const response = await Api.delete(`/api/v1/contato/${id}`);
  window.location.reload()
}
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
                <th>id</th>
                <th>Nome</th>
                <th>Email</th>
                <th>Número</th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="(contato, index) in contatos" :key="index">
                <td>{{ contato.id }}</td>
                <td>{{ contato.nome }}</td>
                <td>{{ contato.email }}</td>
                <td>{{ contato.numero }}</td>
                <Button label="Editar" @click="redirectToEdit(contato.id)" />
                <Button label="Deletar" severity="danger" @click="DeleteContact(contato.id)" />
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

.container {
  margin-top: 15px;
}

Button {
  margin-left: 15px
}

td {
  margin-bottom: 5px;
  border-bottom: 1px solid whitesmoke;
  border-right: 1px solid whitesmoke;
  border-radius: 5px;
}
</style>
