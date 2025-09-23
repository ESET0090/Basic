
import React from 'react'
import { Link } from 'react-router-dom'

export default function NavBar() {
  return (
    <div>
        NavBar & nbsp;
        <Link href='/'> home </Link> &nbsp;
        <a href ='/about'> about </a>
    </div>
  )
}

