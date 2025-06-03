<script setup lang="ts">
import Login from './components/Landing/Login.vue';
import Stuff from './components/Landing/Stuff.vue';
import Info from './components/Landing/Info.vue';


//import LandingPage from './pages/LandingPage.vue';
</script>

<template>
  <div class="hello-world">
    <div class="left">
      <Info/>
    </div>
    <div class="right">
      <div class="login">
        <Login/>
      </div>
      <div class="stuff">
        <Stuff/>
      </div>
    </div>
  </div>
</template>

<style scoped>
  .hello-world {
    justify-content: space-between;
    display: flex;
    flex-direction: row;
    border: 1rem solid blue;
    width: 100%;
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
