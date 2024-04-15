
import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import PrimeVue from 'primevue/config'
import 'primevue/resources/themes/aura-dark-blue/theme.css'
import 'primevue/resources/primevue.min.css'
import 'primeicons/primeicons.css'

import InputText from 'primevue/inputtext'
import Button from 'primevue/button'


const app = createApp(App)

app.use(router)
app.use(PrimeVue)
app.component('InputText', InputText)
app.component('Button', Button)

app.mount('#app')
