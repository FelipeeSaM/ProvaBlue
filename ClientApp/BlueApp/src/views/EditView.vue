<script setup>
import { ref, onBeforeMount } from 'vue';
import { useRouter } from 'vue-router'; 
import Api from '../router/Api';

import { useRoute } from 'vue-router';

const route = useRoute()
const contatos = ref([]);
const router = useRouter();

onBeforeMount(async () => {
  // não consegui fazer utilizando algo como windiw.addEventListener('load')...
  const token = localStorage.getItem('token');

  if(token == null) {
    alert("usuário não autenticado")
    router.push('/');
  } else {
    LoadBook();
  }
});

async function LoadBook() {
  try {
    const response = await Api.get(`/api/v1/contato/${route.params.contactId}`);
    contatos.value = response.data;

  } catch(error) {
    alert("Ih, algo deu errado");
    console.log(error);
  }
}

async function confirmEdit() {
try {
  
    const data = {
    id: route.params.contactId,
    nome: contatos.value.nome,
    email: contatos.value.email,
    numero: contatos.value.numero
    };
    const response = await Api.put('/api/v1/contato/', data);

    if(response.data != null) {
      router.push('/contact')
    }
    
} catch (error) {
  console.log(error)
}

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
                <th>Nome</th>
                <th>Email</th>
                <th>Número</th>
              </tr>
            </thead>
            <tbody>
              <td><InputText type="text" v-model="contatos.nome" variant="filled" /></td>
              <td><InputText type="text" v-model="contatos.email" variant="filled" /></td>
              <td><InputText type="text" v-model="contatos.numero" variant="filled" /></td>
              <Button label="Confirmar" severity="Info" @click="confirmEdit()" />
              <Button label="Voltar" severity="secondary" @click="router.back()" />
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
}
</style>
