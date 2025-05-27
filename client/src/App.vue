<script setup lang="ts">
import HelloWorld from './components/HelloWorld.vue'

//import LandingPage from './pages/LandingPage.vue';
</script>

<template>
  <div class="hello-world">
    <HelloWorld msg="Lets Ducking Game"/>

    <div class="test-now">
      <div>
        Login
      </div>
      <div>
        Your Stuff
      </div>
    </div>
  </div>
</template>

<style scoped>
  .hello-world {
    justify-content: space-between;
    display: flex;
    flex-direction: row;
  }
  .test-now {
    justify-content: center;
    display: flex;
    flex-direction: column;
  }
  .left, .right {
    flex: 1;
    padding: 40px;
  }

</style>
