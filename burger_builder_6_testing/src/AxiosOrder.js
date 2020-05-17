import axios from 'axios'

//axios instance created which can be used in different files
const instance = axios.create ({
    baseURL:'https://react-my-burgur-c4e5f.firebaseio.com/'
});

export default instance;