<script setup>
import { RouterLink, RouterView } from 'vue-router'

</script>

<template>
  <header>
    
  </header>

  <div class="container">
    <div class="wrapper">
      <nav>
        <RouterLink to="/">Home</RouterLink>
        <RouterLink to="/about">About</RouterLink>
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
