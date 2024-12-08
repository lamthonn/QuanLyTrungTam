<template>
  <!-- Navbar -->
  <nav class="navbar navbar-expand-lg bg-light navbar-light">
    <div class="container">
      <a class="navbar-brand" href="#"><img id="MDB-logo" src="../assets/logo.jpg" alt="MDB Logo" draggable="false"
          height="60" /></a>
      <button class="navbar-toggler" type="button" data-mdb-toggle="collapse" data-mdb-target="#navbarSupportedContent"
        aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
        <i class="fas fa-bars"></i>
      </button>
      <div class="collapse navbar-collapse" id="navbarSupportedContent">
        <ul class="navbar-nav ms-auto align-items-center">
          <li class="nav-item">
            <router-link class="nav-link mx-2" to="/">Trang Chủ</router-link>
          </li>

          <li class="nav-item">
            <router-link class="nav-link mx-2" to="/recourses" v-if="RoleData !== '' || Role !== ''">Khóa
              Học</router-link>
          </li>
          <!-- <li class="nav-item">
          <router-link class="nav-link mx-2" to="/socialMedia">Xã Hội</router-link>
        </li> -->
          <li class="nav-item">
            <router-link class="nav-link mx-2" to="/notification">Thông báo</router-link>
          </li>
          <li class="nav-item">
            <router-link class="nav-link mx-2" to="/Schedule" v-if="loginData === true || logined === 'true'">Thời khóa biểu</router-link>
          </li>
          <li class="nav-item">
            <router-link class="nav-link mx-2" to="/socialMedia">Xã hội</router-link>
          </li> 
          <li class="nav-item">
            <router-link class="nav-link mx-2" to="/Manage" v-if="RoleData === '1' || Role === '1'">Quản lý</router-link>
          </li> 
          <li class="nav-item ms-3" v-if="loginData === true || logined === 'true'">
            <a-dropdown-button>
              {{ usernameData ? usernameData : username }}
              <template #overlay>
                <a-menu @click="handleMenuClick">
                  <a-menu-item key="1" v-if="Role !== '1'">
                    <router-link to="/information">Thông tin cá nhân</router-link>
                  </a-menu-item>
                  <a-menu-item key="2" @click="LogOut">
                    Đăng xuất
                  </a-menu-item>
                </a-menu>
              </template>
              <template #icon>
                <UserOutlined />
              </template>
            </a-dropdown-button>
          </li>
          <li class="nav-item ms-3" v-else>
            <router-link class="btn btn-black btn-primary" to="/login" style="margin-right:5px;">Đăng nhập</router-link>
            <router-link class="btn btn-black btn-primary" to="/register">Đăng ký</router-link>
          </li>
        </ul>
      </div>
    </div>
  </nav>
  <!-- Navbar -->
</template>

<script>
import { computed, ref, watch } from 'vue';
import { useStore } from 'vuex';
import { Menu, MenuItem, DropdownButton } from 'ant-design-vue/es/components'
import { UserOutlined } from '@ant-design/icons-vue';
import { useRouter } from 'vue-router';
export default {
  name: "Header-",
  components: {
    AMenu: Menu,
    AMenuItem: MenuItem,
    ADropdownButton: DropdownButton,
    UserOutlined
  },
  setup() {
    const store = useStore()
    const router = useRouter();

    // localStorage.getItem("LOGINED")
    const logined = ref(localStorage.getItem("LOGINED"));
    const loginData = computed(() => store.state.logined);
    const username = ref(localStorage.getItem("USERNAME"));
    const usernameData = computed(() => store.state.username);
    const Role = ref(localStorage.getItem("ROLE"));
    const RoleData = computed(() => store.state.Role);

    const LogOut = () => {
      store.dispatch('logout')
      logined.value = localStorage.getItem("LOGINED")
      Role.value = localStorage.getItem("ROLE")
      router.push("/");
    }

    return {
      store,
      router,
      logined,
      username,
      usernameData,
      Role,
      loginData,
      RoleData,

      LogOut,
    }
  },
};
</script>

<style>
.navbar-light .navbar-nav .nav-link {
  color: #000;
}
</style>
