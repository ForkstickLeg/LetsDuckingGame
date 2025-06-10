import { createRouter, createWebHistory, useRouter } from 'vue-router'

const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: [{
        path: '/',
        name: 'default',
        component: () => import('../pages/LandingPage.vue'),
    },
    {
        path: '/Landing',
        name: 'Landing',
        component: () => import('../pages/LandingPage.vue'),
    },
    {
        path: '/ForgotPassword',
        name: 'ForgotPassword',
        component: () => import('../pages/ForgotPassword.vue'),
    }
]
    
})

export default router