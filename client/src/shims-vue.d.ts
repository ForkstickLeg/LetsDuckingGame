// This tells TypeScript how to handle Vue.js files automatically

declare module '*.vue' {
    import { DefineComponent } from "vue";

    const component: DefineComponent<{}, {}, any>;

    export default component;
}