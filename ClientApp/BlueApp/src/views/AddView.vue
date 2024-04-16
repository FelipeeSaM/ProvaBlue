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
  }
});

async function AddContact() {
try {
  
    const data = {
    nome: contatos.value.nome,
    email: contatos.value.email,
    numero: contatos.value.numero
    };
    
    const response = await Api.post('/api/v1/contato/', data);

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
              <Button label="Confirmar" severity="Info" @click="AddContact()" />
              <Button label="Voltar" severity="secondary" @click="router.back()" />
            </tbody>
          </table>
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
