<template>
  <div id="app">
    <router-view v-if="!$route.meta.keepAlive"></router-view>
    <keep-alive>
      <router-view v-if="$route.meta.keepAlive"></router-view>
    </keep-alive>

    <!-- <keep-alive>
      <router-view v-if="$route.meta.keepAlive"></router-view>
    </keep-alive>-->
    <Tabbar v-show="$route.meta.navShow"></Tabbar>
    <!-- <router-view /> -->
  </div>
</template>

<script>
import Tabbar from "./components/Tabbar ";
export default {
  name: "App",
  components: { Tabbar }
};
</script>

<style>
</style>
