

<template>
  <div classname="forgot-password">
    <h1>Forgot Password</h1>
    <p>If you have forgotten your password, please enter your email address below and we will send you a link to reset it.</p>
    <form @submit.prevent="handleSubmit">
      <input type="email" placeholder="Enter your email" required />
      <button type="submit">Send Reset Link</button>
    </form>
    
  </div>
</template>

<script>
export default {
  methods: {
    handleSubmit() {
      // Add your submit logic here
      alert('Reset link sent (demo)!');
    }
  }
}
</script>
