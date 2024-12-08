import axios from 'axios'
import { createStore } from 'vuex'
// import createPersistedState from 'vuex-persistedstate';

export default createStore({
  state: {
    Role: '',
    logined: false,
    username:'',
    token:'',

  },
  getters: {
  },
  mutations: {
    REGISTER(state, infor){
      axios.post("https://localhost:7255/api/TaiKhoan/register",infor)
        .then(
          alert("Đăng ký thành công!")
        )
        .catch("đăng ký thất bại!")
    },

    async SETTOKEN(state, AccessToken){
      state.logined = true;
      localStorage.setItem("LOGINED", state.logined)
      state.username = AccessToken.Account;
      localStorage.setItem("USERNAME", state.username)
      state.Role = AccessToken.RoleId;
      localStorage.setItem("ROLE", state.Role)
    },

    LOGOUT(state){
      state.logined = false
      localStorage.setItem('LOGINED',state.logined)
      localStorage.removeItem("USERNAME");
      localStorage.removeItem("ROLE");
    }
  },
  actions: {
    async register({commit}, credentials)
    {
      commit('REGISTER',credentials)
    },

    async login({commit} ,credentials)
    {
      commit('SETTOKEN',credentials)
    },

    logout({commit})
    {
      commit('LOGOUT')
    },
    
  },
  modules: {
  },
  // plugins: [createPersistedState()],
})
