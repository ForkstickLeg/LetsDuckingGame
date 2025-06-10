<template>
  <div class="text-center pa-4">
    <v-btn @click="dialog = true"> Login </v-btn>

    <v-dialog v-model="dialog" width="auto">
      <v-card
        max-width="400"
        prepend-icon="mdi-update"
        text="this is where the login"
        title="lgoin pls"
      >
      <input
              type="text"
              placeholder="Username"
              class="pa-2">
        </input>
        <input
              type="password"
              placeholder="Password"
              class="pa-2">
        </input>
        <nav>
            <RouterLink to="/HelloWorld">Forgot</RouterLink>
            <v-btn text>Register</v-btn>
        </nav>
        
        <template v-slot:actions>
          <v-btn text="Submit" @click="dialog = false"></v-btn>
        </template>
      </v-card>
    </v-dialog>
  </div>
  <main>
    <RouterView>
      
    </RouterView>
  </main>
</template>
<script setup>
import { ref } from "vue";


const dialog = ref(false);
</script>
