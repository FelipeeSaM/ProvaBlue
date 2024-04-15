import Axios from 'axios'

const api = Axios.create( { baseURL : 'https://localhost:7070'} )

export default api;