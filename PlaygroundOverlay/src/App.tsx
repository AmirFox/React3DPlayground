import { Fragment, useState } from 'react'
import {Unity, useUnityContext } from "react-unity-webgl";
import './App.css'

function App() {
  const { unityProvider, sendMessage } = useUnityContext({
    loaderUrl: "/Embedded/Build/Embedded.loader.js",
    dataUrl: "/Embedded/Build/Embedded.data.gz",
    frameworkUrl: "/Embedded/Build/Embedded.framework.js.gz",
    codeUrl: "/Embedded/Build/Embedded.wasm.gz",
  });

  function sendMoveLeft()
  {
    sendMessage("Cube", "MoveLeft");
  }

  function sendMoveRight()
  {
    sendMessage("Cube", "MoveRight");
  }

  function sendMoveUp()
  {
    sendMessage("Cube", "MoveUp");
  }

  function sendMoveDown()
  {
    sendMessage("Cube", "MoveDown");
  }

  return (
    <div className="container">
      <Unity className="unity-container" unityProvider={unityProvider} />
      <div className="button-container">
        <button className="button-left" onClick={sendMoveLeft}>Left</button>
        <button className="button-right" onClick={sendMoveRight}>Right</button>
        <button className="button-up" onClick={sendMoveUp}>Up</button>
        <button className="button-down" onClick={sendMoveDown}>Down</button>
      </div>
    </div>
  );
}

export default App
