import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'

import 'bootstrap/dist/css/bootstrap-grid.min.css'
import 'bootstrap/dist/css/bootstrap-utilities.min.css'
import { Carousel } from 'ant-design-vue'
import 'ant-design-vue/dist/reset.css';

createApp(App)
    .use(store)
    .use(router)
    .use(Carousel)
    .mount('#app')
