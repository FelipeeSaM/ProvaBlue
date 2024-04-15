<script setup>
import { RouterLink, RouterView } from 'vue-router'

</script>

<template>
  <header>
    
  </header>

  <div class="container">
    <div class="wrapper">
      <nav>
        <RouterLink to="/" style="margin-right: 15px;">login</RouterLink>
        <RouterLink to="/contact">Lista de contatos</RouterLink>
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
</style>
