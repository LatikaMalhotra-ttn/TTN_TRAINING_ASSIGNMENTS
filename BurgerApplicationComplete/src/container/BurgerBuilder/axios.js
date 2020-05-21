import axios from "axios";

const axiosInstance = axios.create({
    baseURL:"https://burgerbuilder-reactprac.firebaseio.com/"
});


export default axiosInstance;
