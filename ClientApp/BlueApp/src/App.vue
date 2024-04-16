<script setup>
import { RouterLink, RouterView } from 'vue-router'

function deslogar() {
  localStorage.clear();
  alert("deslogado");
}

</script>

<template>
  <header>
    
  </header>

  <div class="container">
    <div class="wrapper">
      <nav>
        <RouterLink to="/" class="link" >login</RouterLink>
        <RouterLink to="/contact" class="link">Lista de contatos</RouterLink>
        <a @click="deslogar" class="link" >Logout</a>
      </nav>
    </div>
  </div>
  <RouterView />
</template>

<style scoped>
.container {
  display: flex;
  align-items: center;
  justify-content: center;
}

.link {
  margin-right: 15px;
}
</style>
