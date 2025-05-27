<script setup lang="ts">
import HelloWorld from './components/HelloWorld.vue'
import {Info, Login, Stuff} from './components/Landing/*'


//import LandingPage from './pages/LandingPage.vue';
</script>

<template>
  <div class="hello-world">
    <div class="left">
      <HelloWorld msg="Lets Ducking Game"/>
    </div>
    <div class="right">
      <div class="login">
        Login
      </div>
      <div class="stuff">
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
    border: 1rem solid blue
  }
  .left {
    border: 1rem solid red;
  }
  .right {
    justify-content: center;
    display: flex;
    flex-direction: column;
  }
  .left, .right {
    flex: 1;
    padding: 40px;
    
  }
  .login, .stuff {
    height: 25%;
    border: 1rem solid purple;
  }

</style>
