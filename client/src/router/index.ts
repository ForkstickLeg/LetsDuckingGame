import { createRouter, createWebHistory, useRouter } from 'vue-router'

const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: [{
        path: '/',
        name: 'default',
        component: () => import('../pages/DefaultPage.vue'),
    },
    {
        path: '/Landing',
        name: 'Landing',
        component: () => import('../pages/LandingPage.vue'),
    },
    {
        path: '/HelloWorld',
        name: 'HelloWorld',
        component: () => import('../pages/HelloWorld.vue'),
    }
]
    
})

export default router