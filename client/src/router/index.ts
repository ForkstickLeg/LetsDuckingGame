import { createRouter, createWebHistory, useRouter } from 'vue-router'

const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: [{
        path: '/',
        name: '(Optional) Test',
        component: () => import('../pages/LandingPage.vue'),
    }]
})

